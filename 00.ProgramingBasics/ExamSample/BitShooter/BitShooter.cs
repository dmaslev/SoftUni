using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitShooter
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int center = 0;
        int size = 0;
        long mask = 1;
        int left = 0;
        int right = 0;
        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            center = int.Parse(split[0]);
            size = int.Parse(split[1]);
            int starBit = center - size / 2;
            int endBit = center + size / 2;
            if (starBit <0)
            {
                starBit = 0;
            }
            if (endBit>63)
            {
                endBit = 63;
            }
            for (int k = starBit; k <= endBit; k++)
            {
                number = number & ((~mask) << k);
            }            
        }
        Console.WriteLine( Convert.ToString(number,2).PadLeft(64, '0'));
    //    for (int i = 0; i < 32; i++)
    //    {
    //        if ((number & 1) ==1)
    //        {
    //            right++;
    //        }
    //        number = number >> 1;
    //    }
    //    for (int i = 32; i < 64; i++)
    //    {
    //        if ((number & 1) == 1)
    //        {
    //            left++;
    //        }
    //        number = number >> 1;
    //    }
    //    Console.WriteLine("left: {0}", left);
    //    Console.WriteLine("right: {0}", right);
      }
}

