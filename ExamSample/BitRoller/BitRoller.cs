using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitRoller
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        long rolls = long.Parse(Console.ReadLine());
        long nWithoutF = 0;
        long bit = 0;
        long lastBit = 0;

        for (int i = 0; i < f; i++)
        {
            bit = number & (1<< i);
            nWithoutF = nWithoutF | bit;
        }


        for (int i = f + 1; i <= 19; i++)
        {
            bit = number & (1<< i);
            nWithoutF = nWithoutF | (bit>>1);
        }
        
        
        for (long i = 0; i < rolls; i++)
        {
            lastBit = nWithoutF & 1;
            nWithoutF = nWithoutF >> 1;
            nWithoutF = nWithoutF | (lastBit << 17);
        }
        long result = 0;
        for (int i = 0; i < f; i++)
        {
            lastBit = nWithoutF & (1<<i);
            result = result | lastBit;
        }
        result = result | (number & (1 << f));
        for (int i = f; i < 19; i++)
        {
            bit = nWithoutF & (1 << i);
            result = result | (bit<<1);
        }

        Console.WriteLine(result);
    }
}

