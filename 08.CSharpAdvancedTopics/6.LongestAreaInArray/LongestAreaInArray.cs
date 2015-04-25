using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] elements = new string[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = Console.ReadLine();

            }
            int countEqualElements = 0;
            string current = elements[0];
            int maxLenght = 0;
            string printStr = current;
            for (int i = 0; i < elements.Length; i++)
            {
                if (current == elements[i])
                {
                    countEqualElements++;
                }
                else
                {
                    current = elements[i];
                    countEqualElements = 1;
                }
                if (countEqualElements > maxLenght)
                {
                    maxLenght = countEqualElements;
                    printStr = current;
                }
            }
            Console.WriteLine(countEqualElements);

            for (int i = 0; i < maxLenght; i++)
            {
                Console.WriteLine(printStr);
            }
        }
    }
}
