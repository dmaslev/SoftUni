using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheatSheet
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        long v = int.Parse(Console.ReadLine());
        long h = int.Parse(Console.ReadLine());
        long number = 0;
        long startNumber = v * h;

        for (long rows = v; rows < v+r; rows++)
        {
            for (long cows = h; cows < h+c; cows++)
            {
                number = rows * cows;
                Console.Write(number+ " ");
            }
            Console.WriteLine();
        }
    }
}
