using System;
using System.Collections;
using System.Collections.Generic;

namespace Mono.CSharp
{
#if !NET_4_0 && !MOBILE_DYNAMIC
	public class Tuple<T1, T2> : IEquatable<Tuple<T1, T2>>
	{
		public Tuple(T1 item1, T2 item2)
		{
			Item1 = item1;
			Item2 = item2;
		}

		public T1 Item1 { get; private set; }
		public T2 Item2 { get; private set; }

		public override int GetHashCode()
		{
			return Item1.GetHashCode() ^ Item2.GetHashCode();
		}

		#region IEquatable<Tuple<T1,T2>> Members

		public bool Equals(Tuple<T1, T2> other)
		{
			return EqualityComparer<T1>.Default.Equals(Item1, other.Item1) &&
				EqualityComparer<T2>.Default.Equals(Item2, other.Item2);
		}

		#endregion
	}

	public class Tuple<T1, T2, T3> : IEquatable<Tuple<T1, T2, T3>>
	{
		public Tuple(T1 item1, T2 item2, T3 item3)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}

		public T1 Item1 { get; private set; }
		public T2 Item2 { get; private set; }
		public T3 Item3 { get; private set; }

		public override int GetHashCode()
		{
			return Item1.GetHashCode() ^ Item2.GetHashCode() ^ Item3.GetHashCode();
		}

		#region IEquatable<Tuple<T1,T2>> Members

		public bool Equals(Tuple<T1, T2, T3> other)
		{
			return EqualityComparer<T1>.Default.Equals(Item1, other.Item1) &&
				EqualityComparer<T2>.Default.Equals(Item2, other.Item2) &&
				EqualityComparer<T3>.Default.Equals(Item3, other.Item3);
		}

		#endregion
	}

	static class Tuple
	{
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return new Tuple<T1, T2>(item1, item2);
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return new Tuple<T1, T2, T3>(item1, item2, item3);
		}
	}
#endif

}

