using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HouseWithWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < 2 * n + 2; row++)
        {
            for (int col = 0; col < 2*n -1; col++)
            {
                if (row == n  || row == 2*n +1)
                {
                    Console.Write('*');                   
                }
                else if ((col == 0 || col == 2 * n - 2 )&& row>n)
                {
                    Console.Write('*');
                }
                else if (col - row == n- 1)
                {
                    Console.Write('*');
                }
                else if (col + row == n - 1)
                {
                    Console.Write('*');
                }
                else if (row > n + n/4  && row <= 2*n - n/4 && col > n/ 2 && col < 2*n - 2 - n/2)
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

