using System;
using System.Collections.Generic;
using System.Linq;

namespace NexBid.Shared.Core.Extensions;

public static class EnumerableTupleExtension
{
    public static bool ContainsItem<T>(this IEnumerable<Tuple<T, T>> value, T item1, T item2)
    {
        return value.Any(item => item.Item1!.Equals(item1) && item.Item2!.Equals(item2));
    }
}