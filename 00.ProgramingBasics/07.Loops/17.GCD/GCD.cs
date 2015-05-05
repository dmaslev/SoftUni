using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.GCD
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (true)
            {
                int remainder = a % b;

                a = b;
                b = remainder;

                if (remainder == 0)
                {
                    break;
                }
            }
            Console.WriteLine(a);

        }
    }
}
