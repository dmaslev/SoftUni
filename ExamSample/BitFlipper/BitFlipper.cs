using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong bit = 0;
        ulong mask = 7;

        for (int i = 63; i > 1; i--)
        {
            bit = (number >> i) & 1;
            if (bit == ((number>> i-1) & 1))
            {
                if (bit == ((number>> i-2) & 1))
                {
                    number = number ^ (mask<<i-2);
                    i -= 2;

                }
                else
                {
                    continue;
                }
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(number);
    }
}

