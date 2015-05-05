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
        string top = new string('.', n / 2);
        Console.WriteLine("{0}{1}{0}", top, "*");
        int a = 1;
        for (int i = 1; i < n/2 ; i++)
        {
            string left = new string('.', n / 2 - i);
            string mid = new string ('.', a);
            a += 2;
            Console.WriteLine("{0}{1}{2}{1}{0}", left, "*", mid);
        }
        
        Console.WriteLine(new string('*', n));
        for (int i = 0; i < n/2-1; i++)
        {
            Console.Write(new string('.', n/4));
            Console.Write("*");
            Console.Write(new string('.', n - 2 - 2 *(n/4)));
            Console.Write("*");
            Console.WriteLine(new string('.', n / 4));
        }
        Console.Write(new string('.',n/4));
        Console.Write(new string('*', n - 2* (n/4)));
        Console.WriteLine(new string('.', n / 4));
    }
}

