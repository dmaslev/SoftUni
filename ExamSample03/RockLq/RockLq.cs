using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dots = new string('.', n);
        string star = new string('*', n);
        Console.WriteLine(dots + star + dots);
        for (int i = 0; i < n/2; i++)
        {
            dots = new string('.', n - 2 - 2 * i);
            string middle = new string('.', n + 2 + 4 * i);
            Console.WriteLine(dots + "*" + middle + "*" + dots);
        }
        dots = new string('.', n);
        string middleDots = new string('.', n-2);
        Console.WriteLine("*" + middleDots + "*" + dots +"*"+middleDots+"*");

        for (int i = 0; i < n/2 - 1; i++)
        {
            middleDots = new string('.', n);
            dots = new string('.', n - 4 - 2 * i);
            string secondDots = new string('.', 1 + 2 * i);
            Console.WriteLine("*" + dots + "*" + secondDots +"*" +middleDots+"*" +secondDots + "*" + dots + "*");
        }
        for (int i = 0; i < n-1; i++)
        {
            dots = new string('.', n - 1 - i);
            middleDots = new string('.', n + 2 * i);
            Console.WriteLine(dots + "*" + middleDots + "*" + dots);
        }
        Console.WriteLine(new string('*', 3* n));

    }
}

