using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = 6; //int.Parse(Console.ReadLine());

        for (int rows = 0; rows < n; rows++)
        {
            for (int cows = 0; cows < n; cows++)
            {
                if (rows == cows && rows < n/ 2)
                {
                    Console.Write('\\');
                }
                else if (rows == n - 1 - cows && rows < n / 2)
                {
                    Console.Write('/');

                }
                else if (rows < cows && rows < n - 1 - cows)
                {
                    Console.Write('*');
                }
                else if ( cows == n/2 -1 || cows == n/2 && rows >= n/2 )
                {
                    Console.Write('|');
                }
                else if (rows == n - 1)
                {
                    Console.Write('-');

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

