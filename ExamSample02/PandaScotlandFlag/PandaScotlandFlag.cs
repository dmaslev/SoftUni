using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char ch = 'A';
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == col || row == n-1 -col)
                {
                    Console.Write(ch);
                    if (ch == 'Z')
                    {
                        ch = 'A';
                    }
                    else
                    {
                        ch++;
                    }

                }
                else if (col > row && col< n - row-1)
                {
                    Console.Write('#');
                }
                else if (col < row && col > n - row - 1)
                {
                    Console.Write('#');
                }
                else if (row == n/2)
                {
                    Console.Write('-');

                }
                else
                {
                    Console.Write('~');
                }

            }
            Console.WriteLine();
        }
    }
}

