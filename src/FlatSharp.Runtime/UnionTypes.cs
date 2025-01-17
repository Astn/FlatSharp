﻿/*
 * Copyright 2020 James Courtney
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



namespace FlatSharp
{
	public interface IFlatBufferUnion
	{
	}


				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1> : IFlatBufferUnion

							where T1 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
							where T25 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
				
				protected readonly T25? item25;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
				
				public FlatBufferUnion(T25 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 25;
					this.item25 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public T25 Item25
				{
					get 
					{
						if (this.discriminator == 25)
						{
							return this.item25!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T25? item)
				{
					item = default;
					if (this.discriminator == 25)
					{
						item = this.item25!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24,
System.Action<T25> case25)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											case 25:
						{
							case25(this.item25!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24,
System.Action<TState, T25> case25)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											case 25:
						{
							case25(state, this.item25!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24,
System.Func<T25, TResult> case25)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											case 25:
						{
							return case25(this.item25!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24,
System.Func<TState, T25, TResult> case25)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											case 25:
						{
							return case25(state, this.item25!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													case 25:
								return this.Item25.Equals(otherUnion.Item25);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											case 25:
							return this.Item25.GetHashCode() ^ 25;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
							where T25 : notnull
							where T26 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
				
				protected readonly T25? item25;
				
				
				protected readonly T26? item26;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
				
				public FlatBufferUnion(T25 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 25;
					this.item25 = item;
				}
				
				
				public FlatBufferUnion(T26 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 26;
					this.item26 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public T25 Item25
				{
					get 
					{
						if (this.discriminator == 25)
						{
							return this.item25!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T25? item)
				{
					item = default;
					if (this.discriminator == 25)
					{
						item = this.item25!;
						return true;
					}

					return false;
				}
				
				
				public T26 Item26
				{
					get 
					{
						if (this.discriminator == 26)
						{
							return this.item26!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T26? item)
				{
					item = default;
					if (this.discriminator == 26)
					{
						item = this.item26!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24,
System.Action<T25> case25,
System.Action<T26> case26)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											case 25:
						{
							case25(this.item25!);
							break;
						}
											case 26:
						{
							case26(this.item26!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24,
System.Action<TState, T25> case25,
System.Action<TState, T26> case26)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											case 25:
						{
							case25(state, this.item25!);
							break;
						}
											case 26:
						{
							case26(state, this.item26!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24,
System.Func<T25, TResult> case25,
System.Func<T26, TResult> case26)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											case 25:
						{
							return case25(this.item25!);
						}
											case 26:
						{
							return case26(this.item26!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24,
System.Func<TState, T25, TResult> case25,
System.Func<TState, T26, TResult> case26)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											case 25:
						{
							return case25(state, this.item25!);
						}
											case 26:
						{
							return case26(state, this.item26!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													case 25:
								return this.Item25.Equals(otherUnion.Item25);
													case 26:
								return this.Item26.Equals(otherUnion.Item26);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											case 25:
							return this.Item25.GetHashCode() ^ 25;
											case 26:
							return this.Item26.GetHashCode() ^ 26;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
							where T25 : notnull
							where T26 : notnull
							where T27 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
				
				protected readonly T25? item25;
				
				
				protected readonly T26? item26;
				
				
				protected readonly T27? item27;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
				
				public FlatBufferUnion(T25 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 25;
					this.item25 = item;
				}
				
				
				public FlatBufferUnion(T26 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 26;
					this.item26 = item;
				}
				
				
				public FlatBufferUnion(T27 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 27;
					this.item27 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public T25 Item25
				{
					get 
					{
						if (this.discriminator == 25)
						{
							return this.item25!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T25? item)
				{
					item = default;
					if (this.discriminator == 25)
					{
						item = this.item25!;
						return true;
					}

					return false;
				}
				
				
				public T26 Item26
				{
					get 
					{
						if (this.discriminator == 26)
						{
							return this.item26!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T26? item)
				{
					item = default;
					if (this.discriminator == 26)
					{
						item = this.item26!;
						return true;
					}

					return false;
				}
				
				
				public T27 Item27
				{
					get 
					{
						if (this.discriminator == 27)
						{
							return this.item27!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T27? item)
				{
					item = default;
					if (this.discriminator == 27)
					{
						item = this.item27!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24,
System.Action<T25> case25,
System.Action<T26> case26,
System.Action<T27> case27)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											case 25:
						{
							case25(this.item25!);
							break;
						}
											case 26:
						{
							case26(this.item26!);
							break;
						}
											case 27:
						{
							case27(this.item27!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24,
System.Action<TState, T25> case25,
System.Action<TState, T26> case26,
System.Action<TState, T27> case27)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											case 25:
						{
							case25(state, this.item25!);
							break;
						}
											case 26:
						{
							case26(state, this.item26!);
							break;
						}
											case 27:
						{
							case27(state, this.item27!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24,
System.Func<T25, TResult> case25,
System.Func<T26, TResult> case26,
System.Func<T27, TResult> case27)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											case 25:
						{
							return case25(this.item25!);
						}
											case 26:
						{
							return case26(this.item26!);
						}
											case 27:
						{
							return case27(this.item27!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24,
System.Func<TState, T25, TResult> case25,
System.Func<TState, T26, TResult> case26,
System.Func<TState, T27, TResult> case27)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											case 25:
						{
							return case25(state, this.item25!);
						}
											case 26:
						{
							return case26(state, this.item26!);
						}
											case 27:
						{
							return case27(state, this.item27!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													case 25:
								return this.Item25.Equals(otherUnion.Item25);
													case 26:
								return this.Item26.Equals(otherUnion.Item26);
													case 27:
								return this.Item27.Equals(otherUnion.Item27);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											case 25:
							return this.Item25.GetHashCode() ^ 25;
											case 26:
							return this.Item26.GetHashCode() ^ 26;
											case 27:
							return this.Item27.GetHashCode() ^ 27;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
							where T25 : notnull
							where T26 : notnull
							where T27 : notnull
							where T28 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
				
				protected readonly T25? item25;
				
				
				protected readonly T26? item26;
				
				
				protected readonly T27? item27;
				
				
				protected readonly T28? item28;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
				
				public FlatBufferUnion(T25 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 25;
					this.item25 = item;
				}
				
				
				public FlatBufferUnion(T26 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 26;
					this.item26 = item;
				}
				
				
				public FlatBufferUnion(T27 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 27;
					this.item27 = item;
				}
				
				
				public FlatBufferUnion(T28 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 28;
					this.item28 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public T25 Item25
				{
					get 
					{
						if (this.discriminator == 25)
						{
							return this.item25!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T25? item)
				{
					item = default;
					if (this.discriminator == 25)
					{
						item = this.item25!;
						return true;
					}

					return false;
				}
				
				
				public T26 Item26
				{
					get 
					{
						if (this.discriminator == 26)
						{
							return this.item26!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T26? item)
				{
					item = default;
					if (this.discriminator == 26)
					{
						item = this.item26!;
						return true;
					}

					return false;
				}
				
				
				public T27 Item27
				{
					get 
					{
						if (this.discriminator == 27)
						{
							return this.item27!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T27? item)
				{
					item = default;
					if (this.discriminator == 27)
					{
						item = this.item27!;
						return true;
					}

					return false;
				}
				
				
				public T28 Item28
				{
					get 
					{
						if (this.discriminator == 28)
						{
							return this.item28!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T28? item)
				{
					item = default;
					if (this.discriminator == 28)
					{
						item = this.item28!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24,
System.Action<T25> case25,
System.Action<T26> case26,
System.Action<T27> case27,
System.Action<T28> case28)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											case 25:
						{
							case25(this.item25!);
							break;
						}
											case 26:
						{
							case26(this.item26!);
							break;
						}
											case 27:
						{
							case27(this.item27!);
							break;
						}
											case 28:
						{
							case28(this.item28!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24,
System.Action<TState, T25> case25,
System.Action<TState, T26> case26,
System.Action<TState, T27> case27,
System.Action<TState, T28> case28)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											case 25:
						{
							case25(state, this.item25!);
							break;
						}
											case 26:
						{
							case26(state, this.item26!);
							break;
						}
											case 27:
						{
							case27(state, this.item27!);
							break;
						}
											case 28:
						{
							case28(state, this.item28!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24,
System.Func<T25, TResult> case25,
System.Func<T26, TResult> case26,
System.Func<T27, TResult> case27,
System.Func<T28, TResult> case28)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											case 25:
						{
							return case25(this.item25!);
						}
											case 26:
						{
							return case26(this.item26!);
						}
											case 27:
						{
							return case27(this.item27!);
						}
											case 28:
						{
							return case28(this.item28!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24,
System.Func<TState, T25, TResult> case25,
System.Func<TState, T26, TResult> case26,
System.Func<TState, T27, TResult> case27,
System.Func<TState, T28, TResult> case28)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											case 25:
						{
							return case25(state, this.item25!);
						}
											case 26:
						{
							return case26(state, this.item26!);
						}
											case 27:
						{
							return case27(state, this.item27!);
						}
											case 28:
						{
							return case28(state, this.item28!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													case 25:
								return this.Item25.Equals(otherUnion.Item25);
													case 26:
								return this.Item26.Equals(otherUnion.Item26);
													case 27:
								return this.Item27.Equals(otherUnion.Item27);
													case 28:
								return this.Item28.Equals(otherUnion.Item28);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											case 25:
							return this.Item25.GetHashCode() ^ 25;
											case 26:
							return this.Item26.GetHashCode() ^ 26;
											case 27:
							return this.Item27.GetHashCode() ^ 27;
											case 28:
							return this.Item28.GetHashCode() ^ 28;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
							where T25 : notnull
							where T26 : notnull
							where T27 : notnull
							where T28 : notnull
							where T29 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
				
				protected readonly T25? item25;
				
				
				protected readonly T26? item26;
				
				
				protected readonly T27? item27;
				
				
				protected readonly T28? item28;
				
				
				protected readonly T29? item29;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
				
				public FlatBufferUnion(T25 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 25;
					this.item25 = item;
				}
				
				
				public FlatBufferUnion(T26 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 26;
					this.item26 = item;
				}
				
				
				public FlatBufferUnion(T27 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 27;
					this.item27 = item;
				}
				
				
				public FlatBufferUnion(T28 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 28;
					this.item28 = item;
				}
				
				
				public FlatBufferUnion(T29 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 29;
					this.item29 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public T25 Item25
				{
					get 
					{
						if (this.discriminator == 25)
						{
							return this.item25!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T25? item)
				{
					item = default;
					if (this.discriminator == 25)
					{
						item = this.item25!;
						return true;
					}

					return false;
				}
				
				
				public T26 Item26
				{
					get 
					{
						if (this.discriminator == 26)
						{
							return this.item26!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T26? item)
				{
					item = default;
					if (this.discriminator == 26)
					{
						item = this.item26!;
						return true;
					}

					return false;
				}
				
				
				public T27 Item27
				{
					get 
					{
						if (this.discriminator == 27)
						{
							return this.item27!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T27? item)
				{
					item = default;
					if (this.discriminator == 27)
					{
						item = this.item27!;
						return true;
					}

					return false;
				}
				
				
				public T28 Item28
				{
					get 
					{
						if (this.discriminator == 28)
						{
							return this.item28!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T28? item)
				{
					item = default;
					if (this.discriminator == 28)
					{
						item = this.item28!;
						return true;
					}

					return false;
				}
				
				
				public T29 Item29
				{
					get 
					{
						if (this.discriminator == 29)
						{
							return this.item29!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T29? item)
				{
					item = default;
					if (this.discriminator == 29)
					{
						item = this.item29!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24,
System.Action<T25> case25,
System.Action<T26> case26,
System.Action<T27> case27,
System.Action<T28> case28,
System.Action<T29> case29)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											case 25:
						{
							case25(this.item25!);
							break;
						}
											case 26:
						{
							case26(this.item26!);
							break;
						}
											case 27:
						{
							case27(this.item27!);
							break;
						}
											case 28:
						{
							case28(this.item28!);
							break;
						}
											case 29:
						{
							case29(this.item29!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24,
System.Action<TState, T25> case25,
System.Action<TState, T26> case26,
System.Action<TState, T27> case27,
System.Action<TState, T28> case28,
System.Action<TState, T29> case29)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											case 25:
						{
							case25(state, this.item25!);
							break;
						}
											case 26:
						{
							case26(state, this.item26!);
							break;
						}
											case 27:
						{
							case27(state, this.item27!);
							break;
						}
											case 28:
						{
							case28(state, this.item28!);
							break;
						}
											case 29:
						{
							case29(state, this.item29!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24,
System.Func<T25, TResult> case25,
System.Func<T26, TResult> case26,
System.Func<T27, TResult> case27,
System.Func<T28, TResult> case28,
System.Func<T29, TResult> case29)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											case 25:
						{
							return case25(this.item25!);
						}
											case 26:
						{
							return case26(this.item26!);
						}
											case 27:
						{
							return case27(this.item27!);
						}
											case 28:
						{
							return case28(this.item28!);
						}
											case 29:
						{
							return case29(this.item29!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24,
System.Func<TState, T25, TResult> case25,
System.Func<TState, T26, TResult> case26,
System.Func<TState, T27, TResult> case27,
System.Func<TState, T28, TResult> case28,
System.Func<TState, T29, TResult> case29)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											case 25:
						{
							return case25(state, this.item25!);
						}
											case 26:
						{
							return case26(state, this.item26!);
						}
											case 27:
						{
							return case27(state, this.item27!);
						}
											case 28:
						{
							return case28(state, this.item28!);
						}
											case 29:
						{
							return case29(state, this.item29!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													case 25:
								return this.Item25.Equals(otherUnion.Item25);
													case 26:
								return this.Item26.Equals(otherUnion.Item26);
													case 27:
								return this.Item27.Equals(otherUnion.Item27);
													case 28:
								return this.Item28.Equals(otherUnion.Item28);
													case 29:
								return this.Item29.Equals(otherUnion.Item29);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											case 25:
							return this.Item25.GetHashCode() ^ 25;
											case 26:
							return this.Item26.GetHashCode() ^ 26;
											case 27:
							return this.Item27.GetHashCode() ^ 27;
											case 28:
							return this.Item28.GetHashCode() ^ 28;
											case 29:
							return this.Item29.GetHashCode() ^ 29;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
				[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
			public class FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> : IFlatBufferUnion

							where T1 : notnull
							where T2 : notnull
							where T3 : notnull
							where T4 : notnull
							where T5 : notnull
							where T6 : notnull
							where T7 : notnull
							where T8 : notnull
							where T9 : notnull
							where T10 : notnull
							where T11 : notnull
							where T12 : notnull
							where T13 : notnull
							where T14 : notnull
							where T15 : notnull
							where T16 : notnull
							where T17 : notnull
							where T18 : notnull
							where T19 : notnull
							where T20 : notnull
							where T21 : notnull
							where T22 : notnull
							where T23 : notnull
							where T24 : notnull
							where T25 : notnull
							where T26 : notnull
							where T27 : notnull
							where T28 : notnull
							where T29 : notnull
							where T30 : notnull
						{
				private readonly byte discriminator;
				
				
				protected readonly T1? item1;
				
				
				protected readonly T2? item2;
				
				
				protected readonly T3? item3;
				
				
				protected readonly T4? item4;
				
				
				protected readonly T5? item5;
				
				
				protected readonly T6? item6;
				
				
				protected readonly T7? item7;
				
				
				protected readonly T8? item8;
				
				
				protected readonly T9? item9;
				
				
				protected readonly T10? item10;
				
				
				protected readonly T11? item11;
				
				
				protected readonly T12? item12;
				
				
				protected readonly T13? item13;
				
				
				protected readonly T14? item14;
				
				
				protected readonly T15? item15;
				
				
				protected readonly T16? item16;
				
				
				protected readonly T17? item17;
				
				
				protected readonly T18? item18;
				
				
				protected readonly T19? item19;
				
				
				protected readonly T20? item20;
				
				
				protected readonly T21? item21;
				
				
				protected readonly T22? item22;
				
				
				protected readonly T23? item23;
				
				
				protected readonly T24? item24;
				
				
				protected readonly T25? item25;
				
				
				protected readonly T26? item26;
				
				
				protected readonly T27? item27;
				
				
				protected readonly T28? item28;
				
				
				protected readonly T29? item29;
				
				
				protected readonly T30? item30;
				
								
				
				public FlatBufferUnion(T1 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 1;
					this.item1 = item;
				}
				
				
				public FlatBufferUnion(T2 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 2;
					this.item2 = item;
				}
				
				
				public FlatBufferUnion(T3 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 3;
					this.item3 = item;
				}
				
				
				public FlatBufferUnion(T4 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 4;
					this.item4 = item;
				}
				
				
				public FlatBufferUnion(T5 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 5;
					this.item5 = item;
				}
				
				
				public FlatBufferUnion(T6 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 6;
					this.item6 = item;
				}
				
				
				public FlatBufferUnion(T7 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 7;
					this.item7 = item;
				}
				
				
				public FlatBufferUnion(T8 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 8;
					this.item8 = item;
				}
				
				
				public FlatBufferUnion(T9 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 9;
					this.item9 = item;
				}
				
				
				public FlatBufferUnion(T10 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 10;
					this.item10 = item;
				}
				
				
				public FlatBufferUnion(T11 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 11;
					this.item11 = item;
				}
				
				
				public FlatBufferUnion(T12 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 12;
					this.item12 = item;
				}
				
				
				public FlatBufferUnion(T13 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 13;
					this.item13 = item;
				}
				
				
				public FlatBufferUnion(T14 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 14;
					this.item14 = item;
				}
				
				
				public FlatBufferUnion(T15 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 15;
					this.item15 = item;
				}
				
				
				public FlatBufferUnion(T16 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 16;
					this.item16 = item;
				}
				
				
				public FlatBufferUnion(T17 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 17;
					this.item17 = item;
				}
				
				
				public FlatBufferUnion(T18 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 18;
					this.item18 = item;
				}
				
				
				public FlatBufferUnion(T19 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 19;
					this.item19 = item;
				}
				
				
				public FlatBufferUnion(T20 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 20;
					this.item20 = item;
				}
				
				
				public FlatBufferUnion(T21 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 21;
					this.item21 = item;
				}
				
				
				public FlatBufferUnion(T22 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 22;
					this.item22 = item;
				}
				
				
				public FlatBufferUnion(T23 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 23;
					this.item23 = item;
				}
				
				
				public FlatBufferUnion(T24 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 24;
					this.item24 = item;
				}
				
				
				public FlatBufferUnion(T25 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 25;
					this.item25 = item;
				}
				
				
				public FlatBufferUnion(T26 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 26;
					this.item26 = item;
				}
				
				
				public FlatBufferUnion(T27 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 27;
					this.item27 = item;
				}
				
				
				public FlatBufferUnion(T28 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 28;
					this.item28 = item;
				}
				
				
				public FlatBufferUnion(T29 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 29;
					this.item29 = item;
				}
				
				
				public FlatBufferUnion(T30 item)
				{
					if (item is null)
					{
						throw new System.ArgumentNullException(nameof(item), "FlatBuffer unions do not accept null items. If you wish to use a null value, simply null out the union on the class.");
					}

					this.discriminator = 30;
					this.item30 = item;
				}
				
							
				public byte Discriminator => this.discriminator;

				
				public T1 Item1
				{
					get 
					{
						if (this.discriminator == 1)
						{
							return this.item1!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? item)
				{
					item = default;
					if (this.discriminator == 1)
					{
						item = this.item1!;
						return true;
					}

					return false;
				}
				
				
				public T2 Item2
				{
					get 
					{
						if (this.discriminator == 2)
						{
							return this.item2!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? item)
				{
					item = default;
					if (this.discriminator == 2)
					{
						item = this.item2!;
						return true;
					}

					return false;
				}
				
				
				public T3 Item3
				{
					get 
					{
						if (this.discriminator == 3)
						{
							return this.item3!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3? item)
				{
					item = default;
					if (this.discriminator == 3)
					{
						item = this.item3!;
						return true;
					}

					return false;
				}
				
				
				public T4 Item4
				{
					get 
					{
						if (this.discriminator == 4)
						{
							return this.item4!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T4? item)
				{
					item = default;
					if (this.discriminator == 4)
					{
						item = this.item4!;
						return true;
					}

					return false;
				}
				
				
				public T5 Item5
				{
					get 
					{
						if (this.discriminator == 5)
						{
							return this.item5!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T5? item)
				{
					item = default;
					if (this.discriminator == 5)
					{
						item = this.item5!;
						return true;
					}

					return false;
				}
				
				
				public T6 Item6
				{
					get 
					{
						if (this.discriminator == 6)
						{
							return this.item6!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T6? item)
				{
					item = default;
					if (this.discriminator == 6)
					{
						item = this.item6!;
						return true;
					}

					return false;
				}
				
				
				public T7 Item7
				{
					get 
					{
						if (this.discriminator == 7)
						{
							return this.item7!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T7? item)
				{
					item = default;
					if (this.discriminator == 7)
					{
						item = this.item7!;
						return true;
					}

					return false;
				}
				
				
				public T8 Item8
				{
					get 
					{
						if (this.discriminator == 8)
						{
							return this.item8!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T8? item)
				{
					item = default;
					if (this.discriminator == 8)
					{
						item = this.item8!;
						return true;
					}

					return false;
				}
				
				
				public T9 Item9
				{
					get 
					{
						if (this.discriminator == 9)
						{
							return this.item9!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T9? item)
				{
					item = default;
					if (this.discriminator == 9)
					{
						item = this.item9!;
						return true;
					}

					return false;
				}
				
				
				public T10 Item10
				{
					get 
					{
						if (this.discriminator == 10)
						{
							return this.item10!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T10? item)
				{
					item = default;
					if (this.discriminator == 10)
					{
						item = this.item10!;
						return true;
					}

					return false;
				}
				
				
				public T11 Item11
				{
					get 
					{
						if (this.discriminator == 11)
						{
							return this.item11!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T11? item)
				{
					item = default;
					if (this.discriminator == 11)
					{
						item = this.item11!;
						return true;
					}

					return false;
				}
				
				
				public T12 Item12
				{
					get 
					{
						if (this.discriminator == 12)
						{
							return this.item12!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T12? item)
				{
					item = default;
					if (this.discriminator == 12)
					{
						item = this.item12!;
						return true;
					}

					return false;
				}
				
				
				public T13 Item13
				{
					get 
					{
						if (this.discriminator == 13)
						{
							return this.item13!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T13? item)
				{
					item = default;
					if (this.discriminator == 13)
					{
						item = this.item13!;
						return true;
					}

					return false;
				}
				
				
				public T14 Item14
				{
					get 
					{
						if (this.discriminator == 14)
						{
							return this.item14!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T14? item)
				{
					item = default;
					if (this.discriminator == 14)
					{
						item = this.item14!;
						return true;
					}

					return false;
				}
				
				
				public T15 Item15
				{
					get 
					{
						if (this.discriminator == 15)
						{
							return this.item15!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T15? item)
				{
					item = default;
					if (this.discriminator == 15)
					{
						item = this.item15!;
						return true;
					}

					return false;
				}
				
				
				public T16 Item16
				{
					get 
					{
						if (this.discriminator == 16)
						{
							return this.item16!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T16? item)
				{
					item = default;
					if (this.discriminator == 16)
					{
						item = this.item16!;
						return true;
					}

					return false;
				}
				
				
				public T17 Item17
				{
					get 
					{
						if (this.discriminator == 17)
						{
							return this.item17!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T17? item)
				{
					item = default;
					if (this.discriminator == 17)
					{
						item = this.item17!;
						return true;
					}

					return false;
				}
				
				
				public T18 Item18
				{
					get 
					{
						if (this.discriminator == 18)
						{
							return this.item18!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T18? item)
				{
					item = default;
					if (this.discriminator == 18)
					{
						item = this.item18!;
						return true;
					}

					return false;
				}
				
				
				public T19 Item19
				{
					get 
					{
						if (this.discriminator == 19)
						{
							return this.item19!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T19? item)
				{
					item = default;
					if (this.discriminator == 19)
					{
						item = this.item19!;
						return true;
					}

					return false;
				}
				
				
				public T20 Item20
				{
					get 
					{
						if (this.discriminator == 20)
						{
							return this.item20!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T20? item)
				{
					item = default;
					if (this.discriminator == 20)
					{
						item = this.item20!;
						return true;
					}

					return false;
				}
				
				
				public T21 Item21
				{
					get 
					{
						if (this.discriminator == 21)
						{
							return this.item21!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T21? item)
				{
					item = default;
					if (this.discriminator == 21)
					{
						item = this.item21!;
						return true;
					}

					return false;
				}
				
				
				public T22 Item22
				{
					get 
					{
						if (this.discriminator == 22)
						{
							return this.item22!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T22? item)
				{
					item = default;
					if (this.discriminator == 22)
					{
						item = this.item22!;
						return true;
					}

					return false;
				}
				
				
				public T23 Item23
				{
					get 
					{
						if (this.discriminator == 23)
						{
							return this.item23!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T23? item)
				{
					item = default;
					if (this.discriminator == 23)
					{
						item = this.item23!;
						return true;
					}

					return false;
				}
				
				
				public T24 Item24
				{
					get 
					{
						if (this.discriminator == 24)
						{
							return this.item24!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T24? item)
				{
					item = default;
					if (this.discriminator == 24)
					{
						item = this.item24!;
						return true;
					}

					return false;
				}
				
				
				public T25 Item25
				{
					get 
					{
						if (this.discriminator == 25)
						{
							return this.item25!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T25? item)
				{
					item = default;
					if (this.discriminator == 25)
					{
						item = this.item25!;
						return true;
					}

					return false;
				}
				
				
				public T26 Item26
				{
					get 
					{
						if (this.discriminator == 26)
						{
							return this.item26!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T26? item)
				{
					item = default;
					if (this.discriminator == 26)
					{
						item = this.item26!;
						return true;
					}

					return false;
				}
				
				
				public T27 Item27
				{
					get 
					{
						if (this.discriminator == 27)
						{
							return this.item27!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T27? item)
				{
					item = default;
					if (this.discriminator == 27)
					{
						item = this.item27!;
						return true;
					}

					return false;
				}
				
				
				public T28 Item28
				{
					get 
					{
						if (this.discriminator == 28)
						{
							return this.item28!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T28? item)
				{
					item = default;
					if (this.discriminator == 28)
					{
						item = this.item28!;
						return true;
					}

					return false;
				}
				
				
				public T29 Item29
				{
					get 
					{
						if (this.discriminator == 29)
						{
							return this.item29!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T29? item)
				{
					item = default;
					if (this.discriminator == 29)
					{
						item = this.item29!;
						return true;
					}

					return false;
				}
				
				
				public T30 Item30
				{
					get 
					{
						if (this.discriminator == 30)
						{
							return this.item30!;
						}
						else
						{
							throw new System.InvalidOperationException();
						}
					}
				}

				public bool TryGet([System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T30? item)
				{
					item = default;
					if (this.discriminator == 30)
					{
						item = this.item30!;
						return true;
					}

					return false;
				}
				
				
				public void Switch(
					System.Action defaultCase,
					System.Action<T1> case1,
System.Action<T2> case2,
System.Action<T3> case3,
System.Action<T4> case4,
System.Action<T5> case5,
System.Action<T6> case6,
System.Action<T7> case7,
System.Action<T8> case8,
System.Action<T9> case9,
System.Action<T10> case10,
System.Action<T11> case11,
System.Action<T12> case12,
System.Action<T13> case13,
System.Action<T14> case14,
System.Action<T15> case15,
System.Action<T16> case16,
System.Action<T17> case17,
System.Action<T18> case18,
System.Action<T19> case19,
System.Action<T20> case20,
System.Action<T21> case21,
System.Action<T22> case22,
System.Action<T23> case23,
System.Action<T24> case24,
System.Action<T25> case25,
System.Action<T26> case26,
System.Action<T27> case27,
System.Action<T28> case28,
System.Action<T29> case29,
System.Action<T30> case30)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(this.item1!);
							break;
						}
											case 2:
						{
							case2(this.item2!);
							break;
						}
											case 3:
						{
							case3(this.item3!);
							break;
						}
											case 4:
						{
							case4(this.item4!);
							break;
						}
											case 5:
						{
							case5(this.item5!);
							break;
						}
											case 6:
						{
							case6(this.item6!);
							break;
						}
											case 7:
						{
							case7(this.item7!);
							break;
						}
											case 8:
						{
							case8(this.item8!);
							break;
						}
											case 9:
						{
							case9(this.item9!);
							break;
						}
											case 10:
						{
							case10(this.item10!);
							break;
						}
											case 11:
						{
							case11(this.item11!);
							break;
						}
											case 12:
						{
							case12(this.item12!);
							break;
						}
											case 13:
						{
							case13(this.item13!);
							break;
						}
											case 14:
						{
							case14(this.item14!);
							break;
						}
											case 15:
						{
							case15(this.item15!);
							break;
						}
											case 16:
						{
							case16(this.item16!);
							break;
						}
											case 17:
						{
							case17(this.item17!);
							break;
						}
											case 18:
						{
							case18(this.item18!);
							break;
						}
											case 19:
						{
							case19(this.item19!);
							break;
						}
											case 20:
						{
							case20(this.item20!);
							break;
						}
											case 21:
						{
							case21(this.item21!);
							break;
						}
											case 22:
						{
							case22(this.item22!);
							break;
						}
											case 23:
						{
							case23(this.item23!);
							break;
						}
											case 24:
						{
							case24(this.item24!);
							break;
						}
											case 25:
						{
							case25(this.item25!);
							break;
						}
											case 26:
						{
							case26(this.item26!);
							break;
						}
											case 27:
						{
							case27(this.item27!);
							break;
						}
											case 28:
						{
							case28(this.item28!);
							break;
						}
											case 29:
						{
							case29(this.item29!);
							break;
						}
											case 30:
						{
							case30(this.item30!);
							break;
						}
											default:
							defaultCase();
							break;
					}
				}

				public void Switch<TState>(
					TState state,
					System.Action<TState> defaultCase,
					System.Action<TState, T1> case1,
System.Action<TState, T2> case2,
System.Action<TState, T3> case3,
System.Action<TState, T4> case4,
System.Action<TState, T5> case5,
System.Action<TState, T6> case6,
System.Action<TState, T7> case7,
System.Action<TState, T8> case8,
System.Action<TState, T9> case9,
System.Action<TState, T10> case10,
System.Action<TState, T11> case11,
System.Action<TState, T12> case12,
System.Action<TState, T13> case13,
System.Action<TState, T14> case14,
System.Action<TState, T15> case15,
System.Action<TState, T16> case16,
System.Action<TState, T17> case17,
System.Action<TState, T18> case18,
System.Action<TState, T19> case19,
System.Action<TState, T20> case20,
System.Action<TState, T21> case21,
System.Action<TState, T22> case22,
System.Action<TState, T23> case23,
System.Action<TState, T24> case24,
System.Action<TState, T25> case25,
System.Action<TState, T26> case26,
System.Action<TState, T27> case27,
System.Action<TState, T28> case28,
System.Action<TState, T29> case29,
System.Action<TState, T30> case30)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							case1(state, this.item1!);
							break;
						}
											case 2:
						{
							case2(state, this.item2!);
							break;
						}
											case 3:
						{
							case3(state, this.item3!);
							break;
						}
											case 4:
						{
							case4(state, this.item4!);
							break;
						}
											case 5:
						{
							case5(state, this.item5!);
							break;
						}
											case 6:
						{
							case6(state, this.item6!);
							break;
						}
											case 7:
						{
							case7(state, this.item7!);
							break;
						}
											case 8:
						{
							case8(state, this.item8!);
							break;
						}
											case 9:
						{
							case9(state, this.item9!);
							break;
						}
											case 10:
						{
							case10(state, this.item10!);
							break;
						}
											case 11:
						{
							case11(state, this.item11!);
							break;
						}
											case 12:
						{
							case12(state, this.item12!);
							break;
						}
											case 13:
						{
							case13(state, this.item13!);
							break;
						}
											case 14:
						{
							case14(state, this.item14!);
							break;
						}
											case 15:
						{
							case15(state, this.item15!);
							break;
						}
											case 16:
						{
							case16(state, this.item16!);
							break;
						}
											case 17:
						{
							case17(state, this.item17!);
							break;
						}
											case 18:
						{
							case18(state, this.item18!);
							break;
						}
											case 19:
						{
							case19(state, this.item19!);
							break;
						}
											case 20:
						{
							case20(state, this.item20!);
							break;
						}
											case 21:
						{
							case21(state, this.item21!);
							break;
						}
											case 22:
						{
							case22(state, this.item22!);
							break;
						}
											case 23:
						{
							case23(state, this.item23!);
							break;
						}
											case 24:
						{
							case24(state, this.item24!);
							break;
						}
											case 25:
						{
							case25(state, this.item25!);
							break;
						}
											case 26:
						{
							case26(state, this.item26!);
							break;
						}
											case 27:
						{
							case27(state, this.item27!);
							break;
						}
											case 28:
						{
							case28(state, this.item28!);
							break;
						}
											case 29:
						{
							case29(state, this.item29!);
							break;
						}
											case 30:
						{
							case30(state, this.item30!);
							break;
						}
											default:
							defaultCase(state);
							break;
					}
				}

				
				public TResult Switch<TResult>(
					System.Func<TResult> defaultCase,
					System.Func<T1, TResult> case1,
System.Func<T2, TResult> case2,
System.Func<T3, TResult> case3,
System.Func<T4, TResult> case4,
System.Func<T5, TResult> case5,
System.Func<T6, TResult> case6,
System.Func<T7, TResult> case7,
System.Func<T8, TResult> case8,
System.Func<T9, TResult> case9,
System.Func<T10, TResult> case10,
System.Func<T11, TResult> case11,
System.Func<T12, TResult> case12,
System.Func<T13, TResult> case13,
System.Func<T14, TResult> case14,
System.Func<T15, TResult> case15,
System.Func<T16, TResult> case16,
System.Func<T17, TResult> case17,
System.Func<T18, TResult> case18,
System.Func<T19, TResult> case19,
System.Func<T20, TResult> case20,
System.Func<T21, TResult> case21,
System.Func<T22, TResult> case22,
System.Func<T23, TResult> case23,
System.Func<T24, TResult> case24,
System.Func<T25, TResult> case25,
System.Func<T26, TResult> case26,
System.Func<T27, TResult> case27,
System.Func<T28, TResult> case28,
System.Func<T29, TResult> case29,
System.Func<T30, TResult> case30)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(this.item1!);
						}
											case 2:
						{
							return case2(this.item2!);
						}
											case 3:
						{
							return case3(this.item3!);
						}
											case 4:
						{
							return case4(this.item4!);
						}
											case 5:
						{
							return case5(this.item5!);
						}
											case 6:
						{
							return case6(this.item6!);
						}
											case 7:
						{
							return case7(this.item7!);
						}
											case 8:
						{
							return case8(this.item8!);
						}
											case 9:
						{
							return case9(this.item9!);
						}
											case 10:
						{
							return case10(this.item10!);
						}
											case 11:
						{
							return case11(this.item11!);
						}
											case 12:
						{
							return case12(this.item12!);
						}
											case 13:
						{
							return case13(this.item13!);
						}
											case 14:
						{
							return case14(this.item14!);
						}
											case 15:
						{
							return case15(this.item15!);
						}
											case 16:
						{
							return case16(this.item16!);
						}
											case 17:
						{
							return case17(this.item17!);
						}
											case 18:
						{
							return case18(this.item18!);
						}
											case 19:
						{
							return case19(this.item19!);
						}
											case 20:
						{
							return case20(this.item20!);
						}
											case 21:
						{
							return case21(this.item21!);
						}
											case 22:
						{
							return case22(this.item22!);
						}
											case 23:
						{
							return case23(this.item23!);
						}
											case 24:
						{
							return case24(this.item24!);
						}
											case 25:
						{
							return case25(this.item25!);
						}
											case 26:
						{
							return case26(this.item26!);
						}
											case 27:
						{
							return case27(this.item27!);
						}
											case 28:
						{
							return case28(this.item28!);
						}
											case 29:
						{
							return case29(this.item29!);
						}
											case 30:
						{
							return case30(this.item30!);
						}
											default:
							return defaultCase();
					}
				}

				public TResult Switch<TState, TResult>(
					TState state,
					System.Func<TState, TResult> defaultCase,
					System.Func<TState, T1, TResult> case1,
System.Func<TState, T2, TResult> case2,
System.Func<TState, T3, TResult> case3,
System.Func<TState, T4, TResult> case4,
System.Func<TState, T5, TResult> case5,
System.Func<TState, T6, TResult> case6,
System.Func<TState, T7, TResult> case7,
System.Func<TState, T8, TResult> case8,
System.Func<TState, T9, TResult> case9,
System.Func<TState, T10, TResult> case10,
System.Func<TState, T11, TResult> case11,
System.Func<TState, T12, TResult> case12,
System.Func<TState, T13, TResult> case13,
System.Func<TState, T14, TResult> case14,
System.Func<TState, T15, TResult> case15,
System.Func<TState, T16, TResult> case16,
System.Func<TState, T17, TResult> case17,
System.Func<TState, T18, TResult> case18,
System.Func<TState, T19, TResult> case19,
System.Func<TState, T20, TResult> case20,
System.Func<TState, T21, TResult> case21,
System.Func<TState, T22, TResult> case22,
System.Func<TState, T23, TResult> case23,
System.Func<TState, T24, TResult> case24,
System.Func<TState, T25, TResult> case25,
System.Func<TState, T26, TResult> case26,
System.Func<TState, T27, TResult> case27,
System.Func<TState, T28, TResult> case28,
System.Func<TState, T29, TResult> case29,
System.Func<TState, T30, TResult> case30)
				{
					switch (this.discriminator)
					{
											case 1:
						{
							return case1(state, this.item1!);
						}
											case 2:
						{
							return case2(state, this.item2!);
						}
											case 3:
						{
							return case3(state, this.item3!);
						}
											case 4:
						{
							return case4(state, this.item4!);
						}
											case 5:
						{
							return case5(state, this.item5!);
						}
											case 6:
						{
							return case6(state, this.item6!);
						}
											case 7:
						{
							return case7(state, this.item7!);
						}
											case 8:
						{
							return case8(state, this.item8!);
						}
											case 9:
						{
							return case9(state, this.item9!);
						}
											case 10:
						{
							return case10(state, this.item10!);
						}
											case 11:
						{
							return case11(state, this.item11!);
						}
											case 12:
						{
							return case12(state, this.item12!);
						}
											case 13:
						{
							return case13(state, this.item13!);
						}
											case 14:
						{
							return case14(state, this.item14!);
						}
											case 15:
						{
							return case15(state, this.item15!);
						}
											case 16:
						{
							return case16(state, this.item16!);
						}
											case 17:
						{
							return case17(state, this.item17!);
						}
											case 18:
						{
							return case18(state, this.item18!);
						}
											case 19:
						{
							return case19(state, this.item19!);
						}
											case 20:
						{
							return case20(state, this.item20!);
						}
											case 21:
						{
							return case21(state, this.item21!);
						}
											case 22:
						{
							return case22(state, this.item22!);
						}
											case 23:
						{
							return case23(state, this.item23!);
						}
											case 24:
						{
							return case24(state, this.item24!);
						}
											case 25:
						{
							return case25(state, this.item25!);
						}
											case 26:
						{
							return case26(state, this.item26!);
						}
											case 27:
						{
							return case27(state, this.item27!);
						}
											case 28:
						{
							return case28(state, this.item28!);
						}
											case 29:
						{
							return case29(state, this.item29!);
						}
											case 30:
						{
							return case30(state, this.item30!);
						}
											default:
							return defaultCase(state);
					}
				}

				public override bool Equals(object? other)
				{
					if (other is FlatBufferUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> otherUnion)
					{
						if (this.discriminator != otherUnion.Discriminator)
						{
							return false;
						}

						switch (this.discriminator)
						{
													case 1:
								return this.Item1.Equals(otherUnion.Item1);
													case 2:
								return this.Item2.Equals(otherUnion.Item2);
													case 3:
								return this.Item3.Equals(otherUnion.Item3);
													case 4:
								return this.Item4.Equals(otherUnion.Item4);
													case 5:
								return this.Item5.Equals(otherUnion.Item5);
													case 6:
								return this.Item6.Equals(otherUnion.Item6);
													case 7:
								return this.Item7.Equals(otherUnion.Item7);
													case 8:
								return this.Item8.Equals(otherUnion.Item8);
													case 9:
								return this.Item9.Equals(otherUnion.Item9);
													case 10:
								return this.Item10.Equals(otherUnion.Item10);
													case 11:
								return this.Item11.Equals(otherUnion.Item11);
													case 12:
								return this.Item12.Equals(otherUnion.Item12);
													case 13:
								return this.Item13.Equals(otherUnion.Item13);
													case 14:
								return this.Item14.Equals(otherUnion.Item14);
													case 15:
								return this.Item15.Equals(otherUnion.Item15);
													case 16:
								return this.Item16.Equals(otherUnion.Item16);
													case 17:
								return this.Item17.Equals(otherUnion.Item17);
													case 18:
								return this.Item18.Equals(otherUnion.Item18);
													case 19:
								return this.Item19.Equals(otherUnion.Item19);
													case 20:
								return this.Item20.Equals(otherUnion.Item20);
													case 21:
								return this.Item21.Equals(otherUnion.Item21);
													case 22:
								return this.Item22.Equals(otherUnion.Item22);
													case 23:
								return this.Item23.Equals(otherUnion.Item23);
													case 24:
								return this.Item24.Equals(otherUnion.Item24);
													case 25:
								return this.Item25.Equals(otherUnion.Item25);
													case 26:
								return this.Item26.Equals(otherUnion.Item26);
													case 27:
								return this.Item27.Equals(otherUnion.Item27);
													case 28:
								return this.Item28.Equals(otherUnion.Item28);
													case 29:
								return this.Item29.Equals(otherUnion.Item29);
													case 30:
								return this.Item30.Equals(otherUnion.Item30);
													default:
								throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
						}
					}
					else
					{
						return false;
					}
				}

				public override int GetHashCode()
				{
					switch (this.discriminator)
					{
											case 1:
							return this.Item1.GetHashCode() ^ 1;
											case 2:
							return this.Item2.GetHashCode() ^ 2;
											case 3:
							return this.Item3.GetHashCode() ^ 3;
											case 4:
							return this.Item4.GetHashCode() ^ 4;
											case 5:
							return this.Item5.GetHashCode() ^ 5;
											case 6:
							return this.Item6.GetHashCode() ^ 6;
											case 7:
							return this.Item7.GetHashCode() ^ 7;
											case 8:
							return this.Item8.GetHashCode() ^ 8;
											case 9:
							return this.Item9.GetHashCode() ^ 9;
											case 10:
							return this.Item10.GetHashCode() ^ 10;
											case 11:
							return this.Item11.GetHashCode() ^ 11;
											case 12:
							return this.Item12.GetHashCode() ^ 12;
											case 13:
							return this.Item13.GetHashCode() ^ 13;
											case 14:
							return this.Item14.GetHashCode() ^ 14;
											case 15:
							return this.Item15.GetHashCode() ^ 15;
											case 16:
							return this.Item16.GetHashCode() ^ 16;
											case 17:
							return this.Item17.GetHashCode() ^ 17;
											case 18:
							return this.Item18.GetHashCode() ^ 18;
											case 19:
							return this.Item19.GetHashCode() ^ 19;
											case 20:
							return this.Item20.GetHashCode() ^ 20;
											case 21:
							return this.Item21.GetHashCode() ^ 21;
											case 22:
							return this.Item22.GetHashCode() ^ 22;
											case 23:
							return this.Item23.GetHashCode() ^ 23;
											case 24:
							return this.Item24.GetHashCode() ^ 24;
											case 25:
							return this.Item25.GetHashCode() ^ 25;
											case 26:
							return this.Item26.GetHashCode() ^ 26;
											case 27:
							return this.Item27.GetHashCode() ^ 27;
											case 28:
							return this.Item28.GetHashCode() ^ 28;
											case 29:
							return this.Item29.GetHashCode() ^ 29;
											case 30:
							return this.Item30.GetHashCode() ^ 30;
											default:
							throw new System.InvalidOperationException("Unexpected discriminator: " + this.discriminator);
					}
				}
			}
	
}