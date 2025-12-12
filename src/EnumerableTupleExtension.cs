using System;
using System.Collections.Generic;

namespace Soenneker.Extensions.Enumerable.Tuple;

public static class EnumerableTupleExtension
{
    /// <summary>
    /// Checks if the first value and second value equal any of the tuples (item1 & item2) in the enumerable
    /// </summary>
    public static bool ContainsItem<TFirst, TSecond>(this IEnumerable<Tuple<TFirst, TSecond>> source, TFirst item1, TSecond item2)
    {
        using IEnumerator<Tuple<TFirst, TSecond>> enumerator = source.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Tuple<TFirst, TSecond> current = enumerator.Current;

            if (EqualityComparer<TFirst>.Default.Equals(current.Item1, item1) &&
                EqualityComparer<TSecond>.Default.Equals(current.Item2, item2))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Checks if the first item and second item in the tuple equal any of the tuples (item1 & item2) in the enumerable
    /// </summary>
    public static bool ContainsItem<TFirst, TSecond>(this IEnumerable<Tuple<TFirst, TSecond>> source, Tuple<TFirst, TSecond> item)
    {
        using IEnumerator<Tuple<TFirst, TSecond>> enumerator = source.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Tuple<TFirst, TSecond> current = enumerator.Current;

            if (EqualityComparer<TFirst>.Default.Equals(current.Item1, item.Item1) &&
                EqualityComparer<TSecond>.Default.Equals(current.Item2, item.Item2))
            {
                return true;
            }
        }

        return false;
    }
}