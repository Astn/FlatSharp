﻿/*
 * Copyright 2021 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
namespace FlatSharp.TypeModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Defines a vector type model.
    /// </summary>
    public abstract class BaseVectorTypeModel : RuntimeTypeModel
    {
        // count of items + padding(uoffset_t);
        protected static readonly int VectorMinSize = sizeof(uint) + SerializationHelpers.GetMaxPadding(sizeof(uint));

        internal BaseVectorTypeModel(Type vectorType, TypeModelContainer provider) : base(vectorType, provider)
        {
        }

        /// <summary>
        /// Gets the schema type.
        /// </summary>
        public override FlatBufferSchemaType SchemaType => FlatBufferSchemaType.Vector;

        /// <summary>
        /// Layout of the vtable.
        /// </summary>
        public override ImmutableArray<PhysicalLayoutElement> PhysicalLayout =>
            new PhysicalLayoutElement[] { new PhysicalLayoutElement(sizeof(uint), sizeof(uint)) }.ToImmutableArray();

        /// <summary>
        /// Vectors are arbitrary in length.
        /// </summary>
        public override bool IsFixedSize => false;

        /// <summary>
        /// Vectors can't be part of structs.
        /// </summary>
        public override bool IsValidStructMember => false;

        /// <summary>
        /// Vectors can be part of tables.
        /// </summary>
        public override bool IsValidTableMember => true;

        /// <summary>
        /// Vectors can't be part of unions.
        /// </summary>
        public override bool IsValidUnionMember => false;

        /// <summary>
        /// Vectors can't be part of vectors.
        /// </summary>
        public override bool IsValidVectorMember => false;

        /// <summary>
        /// Vector's can't be keys of sorted vectors.
        /// </summary>
        public override bool IsValidSortedVectorKey => false;

        /// <summary>
        /// Gets the type model for this vector's elements.
        /// </summary>
        public abstract ITypeModel ItemTypeModel { get; }

        /// <summary>
        /// The name of the length property of this vector type.
        /// </summary>
        public abstract string LengthPropertyName { get; }

        /// <summary>
        /// Vectors are by-reference.
        /// </summary>
        public override bool SerializesInline => false;

        /// <summary>
        /// Gets the size of each member of this vector, with padding for alignment.
        /// </summary>
        public int PaddedMemberInlineSize
        {
            get
            {
                int itemInlineSize = this.ItemTypeModel.PhysicalLayout[0].InlineSize;
                int itemAlignment = this.ItemTypeModel.PhysicalLayout[0].Alignment;

                return itemInlineSize + SerializationHelpers.GetAlignmentError(itemInlineSize, itemAlignment);
            }
        }

        public override bool TryGetUnderlyingVectorType([NotNullWhen(true)] out ITypeModel? typeModel)
        {
            typeModel = this.ItemTypeModel;
            return true;
        }

        public sealed override CodeGeneratedMethod CreateGetMaxSizeMethodBody(GetMaxSizeCodeGenContext context)
        {
            string lengthProperty = $"{context.ValueVariableName}.{this.LengthPropertyName}";

            string body;
            if (this.ItemTypeModel.IsFixedSize)
            {
                // Constant size items. We can reduce these reasonably well.
                body = $"return {VectorMinSize + SerializationHelpers.GetMaxPadding(this.ItemTypeModel.PhysicalLayout[0].Alignment)} + ({this.PaddedMemberInlineSize} * {lengthProperty});";
            }
            else
            {
                string loopBody = $@"
                    {this.GetThrowIfNullStatement("current")}
                    runningSum += {context.MethodNameMap[this.ItemTypeModel.ClrType]}(current);";

                body = $@"
                int count = {lengthProperty};
                int runningSum = {this.MaxInlineSize + VectorMinSize};
                {this.CreateLoop(context.Options, context.ValueVariableName, "count", "current", loopBody)}

                return runningSum;";
            }

            return new CodeGeneratedMethod(body);
        }

        public override CodeGeneratedMethod CreateSerializeMethodBody(SerializationCodeGenContext context)
        {
            var type = this.ClrType;
            var itemTypeModel = this.ItemTypeModel;

            string loopInnerInvocation = context.With(
                valueVariableName: "current",
                offsetVariableName: "vectorOffset").GetSerializeInvocation(itemTypeModel.ClrType);

            string loopBody = $@"
                {this.GetThrowIfNullStatement("current")}
                {loopInnerInvocation};
                vectorOffset += {this.PaddedMemberInlineSize};";

            string body = $@"
                int count = {context.ValueVariableName}.{this.LengthPropertyName};
                int vectorOffset = {context.SerializationContextVariableName}.{nameof(SerializationContext.AllocateVector)}({itemTypeModel.PhysicalLayout[0].Alignment}, count, {this.PaddedMemberInlineSize});
                {context.SpanWriterVariableName}.{nameof(SpanWriterExtensions.WriteUOffset)}({context.SpanVariableName}, {context.OffsetVariableName}, vectorOffset);
                {context.SpanWriterVariableName}.{nameof(SpanWriter.WriteInt)}({context.SpanVariableName}, count, vectorOffset);
                vectorOffset += sizeof(int);

                {this.CreateLoop(context.Options, context.ValueVariableName, "count", "current", loopBody)}";

            return new CodeGeneratedMethod(body);
        }

        /// <summary>
        /// Creates a loop that executes the given body.
        /// </summary>
        protected abstract string CreateLoop(
            FlatBufferSerializerOptions options,
            string vectorVariableName, 
            string numberofItemsVariableName,
            string expectedVariableName, 
            string body);

        public override CodeGeneratedMethod CreateCloneMethodBody(CloneCodeGenContext context)
        {
            string parameters;
            if (this.ItemTypeModel.ClrType.IsValueType)
            {
                parameters = context.ItemVariableName;
            }
            else
            {
                parameters = $"{context.ItemVariableName}, {context.MethodNameMap[this.ItemTypeModel.ClrType]}";
            }

            string body =  $"return {nameof(VectorCloneHelpers)}.{nameof(VectorCloneHelpers.Clone)}<{this.ItemTypeModel.GetCompilableTypeName()}>({parameters});";
            return new CodeGeneratedMethod(body)
            {
                IsMethodInline = true,
            };
        }

        public sealed override void Initialize()
        {
            base.Initialize();
            this.OnInitialize();

            if (this.ItemTypeModel.PhysicalLayout.Length != 1)
            {
                throw new InvalidFlatBufferDefinitionException($"Vectors may only store vtable layouts with one item. Consider a custom vector type model for other vector kinds.");
            }
        }

        public abstract void OnInitialize();

        public override void TraverseObjectGraph(HashSet<Type> seenTypes)
        {
            seenTypes.Add(this.ClrType);
            if (seenTypes.Add(this.ItemTypeModel.ClrType))
            {
                this.ItemTypeModel.TraverseObjectGraph(seenTypes);
            }
        }

        protected string GetThrowIfNullStatement(string variableName)
        {
            if (this.ItemTypeModel.IsNonNullableClrValueType())
            {
                // can't be null.
                return string.Empty;
            }

            return $"{nameof(SerializationHelpers)}.{nameof(SerializationHelpers.EnsureNonNull)}({variableName});";
        }
    }
}
