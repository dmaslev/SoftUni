using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', i), new string('*', n - (2*i)));
        }

        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n/2-i - 1), new string('*', 3 + 2 * i));
        }
    }
}