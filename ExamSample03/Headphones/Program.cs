using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row <= n; row++)
        {
            for (int col = 0; col <= 2*n; col++)
            {
                if (row ==0 & col > n/2-1 && col < 2*n + 1- n/2)
                {
                    Console.Write('*');
                }
                else if (row <= n && (col ==n /2 || col == 2*n-n/2))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');   
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('-', n / 2 - 1- i));
            Console.Write(new string('*', 3 + 2 * i));
            Console.Write(new string('-', n - 2 - 2 * i));
            Console.Write(new string('*', 3 + 2 * i));
            Console.Write(new string('-', n/2 - 1 - i));
            Console.WriteLine();
        }
        for (int i = 0; i < n/2; i++)
        {
            
            Console.Write(new string('-', 1+i));
            Console.Write(new string('*', n- 2 - 2 * i));
            Console.Write(new string('-', 3 + 2 * i));
            Console.Write(new string('*', n - 2 - 2 * i));
            Console.Write(new string('-', 1 + i ));
            Console.WriteLine();
        }
    }
}

