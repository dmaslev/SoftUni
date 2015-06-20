using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods
{
    public static class Extension
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> list = new List<T>();
            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    list.Add(element);
                }
            }
            return list;
        }


        public static TSelector Maax<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate) where TSelector : IComparable
        {
            TSelector max = predicate(collection.First());

            foreach (var element in collection)
            {
                if (max.CompareTo(predicate(element)) < 0)
                {
                    max = predicate(element);
                }
            }

            return max;
        }
        
    }
}
