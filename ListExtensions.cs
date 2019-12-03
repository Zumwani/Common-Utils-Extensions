using System.Collections.Generic;
using System.Linq;

public static class ListExtensions
{

    public static T Random<T>(this IList<T> list)
    {
        if (list?.Count() == 0) return default;
        return list[UnityEngine.Random.Range(0, list.Count())];
    }

}
