using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitSifting
{
    static void Main()
    {
        int countBits = 0;
        long numberToSieve = long.Parse(Console.ReadLine());
        long numberOfSieves = long.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfSieves; i++)
        {
            long sieve = long.Parse(Console.ReadLine());
            long nummberAfter = numberToSieve ^ sieve;
            numberToSieve = nummberAfter & numberToSieve;
        }
        for (int i = 0; i < 64; i++)
        {
            if ((numberToSieve >> i & 1 ) == 1)
            {
                countBits++;
            }
        }
        Console.WriteLine(countBits);
    }
}

