using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods
{
    public static class Extension
    {

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection)
        {
            var matches = new List<T>();


            return matches;
        }
    }
}
