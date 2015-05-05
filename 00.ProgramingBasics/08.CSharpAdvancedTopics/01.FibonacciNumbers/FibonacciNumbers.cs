using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        while (n < 0)
        {
            Console.WriteLine("Invalid input");
            n = int.Parse(Console.ReadLine());
        }
        //long fibN = Fib(n);
        Console.WriteLine(Fib(n));
    }

    private static long Fib(int n)
    {
        long fibonacci = 0;
        if (n <= 1)
        {
            fibonacci = 1;   
        }
        else
        {
            long a = 1;
            long b = 1;
            long c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            fibonacci = c;
        }
        return fibonacci;
    }
}

