using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sunlight
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', 3 * n / 2) + "*" + new string('.', 3 * n / 2));
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string('.', 1 + i) + "*");
            Console.Write(new string('.', (3 * n -5 )/2 - i) + "*");
            Console.Write(new string('.', (3 * n - 5) / 2 - i) + "*");
            Console.Write(new string('.', 1 + i));
            Console.WriteLine();
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.', n));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', n));
        }
        Console.WriteLine(new string('*', 3* n ));
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', n));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', n));
        }
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', n-1 - i) + "*");
            Console.Write(new string('.', (n/2 + i)) + "*");
            Console.Write(new string('.', (n / 2 + i)) + "*");
            Console.Write(new string('.', n - 1 - i) );
            Console.WriteLine();
        }
        Console.WriteLine(new string('.', 3 * n / 2) + "*" + new string('.', 3 * n / 2));



    }
}

