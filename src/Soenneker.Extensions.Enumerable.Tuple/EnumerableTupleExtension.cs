using System;
using System.Collections.Generic;

namespace Soenneker.Extensions.Enumerable.Tuple;

/// <summary>
/// Provides extension methods for working with sequences of tuples, enabling convenient operations such as checking for
/// the presence of specific tuple elements within an enumerable collection.
/// </summary>
/// <remarks>This static class contains methods that extend them to simplify common
/// tuple-based queries. All methods are implemented as extension methods and can be called directly on compatible
/// enumerable collections. Methods in this class use the default equality comparers for tuple element types unless
/// otherwise specified.</remarks>
public static class EnumerableTupleExtension
{
    /// <summary>
    /// Checks if <paramref name="item1"/> and <paramref name="item2"/> match any tuple (Item1 &amp; Item2) in <paramref name="source"/>.
    /// </summary>
    public static bool ContainsItem<TFirst, TSecond>(this IEnumerable<Tuple<TFirst, TSecond>> source, TFirst item1, TSecond item2)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source));

        var comparer1 = EqualityComparer<TFirst>.Default;
        var comparer2 = EqualityComparer<TSecond>.Default;

        foreach (var current in source)
        {
            // If your sequences may contain null tuples, keep this guard; otherwise you can remove it.
            if (current is null)
                continue;

            if (comparer1.Equals(current.Item1, item1) && comparer2.Equals(current.Item2, item2))
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Checks if <paramref name="item"/> matches any tuple (Item1 &amp; Item2) in <paramref name="source"/>.
    /// </summary>
    public static bool ContainsItem<TFirst, TSecond>(this IEnumerable<Tuple<TFirst, TSecond>> source, Tuple<TFirst, TSecond> item)
    {
        if (item is null)
            throw new ArgumentNullException(nameof(item));

        return source.ContainsItem(item.Item1, item.Item2);
    }
}