using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitKiller
{
    static void Main()
    {
        int result = 0;
        int counter = 0;
        int position = 0;
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bitPositon = 7; bitPositon >= 0; bitPositon--)
            {
                if (!((position % step == 1) || (step == 1 && position > 0)))
                {
                    result = result << 1;

                    int bitValue = (number >> bitPositon) & 1;
                    result = result | bitValue;
                    counter++;

                }
                ++position;
                if (counter == 8)
                {
                    Console.WriteLine(result);
                    counter = 0;
                    result = 0;
                }
            }
        }
        if (counter > 0)
        {
            result = result << (8 - counter % 8);
            Console.WriteLine(result);
        }
    }
}

