using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            string first = Console.ReadLine();
            List<string> firstNames = new List<string>(first.Split());
            string second = Console.ReadLine();
            List<string> secondNames = new List<string>(second.Split());

            for (int i = 0; i < firstNames.Count; i++)
            {
                if (second.Contains(firstNames[i]))
                {
                    firstNames.Remove(firstNames[i]);
                    i--;
                }
            }
            foreach (var name in firstNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
