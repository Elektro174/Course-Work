using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
