using System;
using System.Collections.Generic;
using System.Linq;

namespace Soenneker.Extensions.Enumerable.Tuple;

public static class EnumerableTupleExtension
{
    /// <summary>
    /// Checks if the first value and second value equal any of the tuples (item1 & item2) in the enumerable
    /// </summary>
    public static bool ContainsItem<TFirst, TSecond>(this IEnumerable<Tuple<TFirst, TSecond>> value, TFirst item1, TSecond item2)
    {
        return value.Any(x => x.Item1!.Equals(item1) && x.Item2!.Equals(item2));
    }

    /// <summary>
    /// Checks if the first item and second item in the tuple equal any of the tuples (item1 & item2) in the enumerable
    /// </summary>
    public static bool ContainsItem<TFirst, TSecond>(this IEnumerable<Tuple<TFirst, TSecond>> value, Tuple<TFirst, TSecond> item)
    {
        return value.Any(x => x.Item1!.Equals(item.Item1) && x.Item2!.Equals(item.Item2));
    }
}