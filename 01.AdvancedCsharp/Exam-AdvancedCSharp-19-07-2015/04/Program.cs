using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string,ulong>>();
            var dictPop = new Dictionary<string, ulong>();
            while (input != "report")
            {
                string[] info = input.Split('|').ToArray();
                string country = info[1];
                string city = info[0];
                ulong population = ulong.Parse(info[2]);
                if (!dictionary.ContainsKey(info[1]))
                {
                    dictionary[info[1]] = new Dictionary<string, ulong>();
                    dictPop[info[1]] = 0;
                }
                if (!dictionary[country].ContainsKey(info[0]))
                {
                    dictionary[country][city] = population;
                    dictPop[country] += population;
                }



                input = Console.ReadLine();
            }
            ulong pop = 0;

            var sortedPop = dictPop.OrderByDescending(A => A.Value);

            foreach (var item in sortedPop)
            {
                Console.WriteLine("{0} (total population: {1})", item.Key, item.Value);
                var sorted = dictionary[item.Key].OrderByDescending(c => c.Value);
                foreach (var city in sorted)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
