using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }

    }
}

