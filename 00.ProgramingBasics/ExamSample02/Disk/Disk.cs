using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Disk
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                double distance = Math.Sqrt((rows - n/2)*(rows - n/2) + (cols-n/2)*(cols-n/2));
                if (distance<= r)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');

                }
            }
            Console.WriteLine();
        }
    }
}
