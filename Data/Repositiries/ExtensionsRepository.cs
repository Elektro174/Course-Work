using System;
using System.Collections.Generic;

namespace Data.Repositiries
{
    static class ExtensionsRepository
    {
        public static IEnumerable<T> AsObjectSequence<T>(this T obj, Func<T, T> selector)
        {
            while (obj != null)
            {
                yield return obj;
                obj = selector(obj);
            }
        }
    }
}