using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long output = 0;
        long one = 1;
        for (int i = 0; i < n; i++)
        {
            output = 0;
            long number = long.Parse(Console.ReadLine());
            while (number>0)
            {
                output = output << 1;
                long lastBit = number & one;
                number = number >> 1;
                output = output | lastBit;
            }
            Console.WriteLine(output);
        }
    }
}

