using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Row(n);
    }

    private static void Row(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintRow(i);
        }
        for (int a = n-1; a >=1; a--)
        {
            PrintRow(a);
        }
    }

    private static void PrindSecond(int a, int n)
    {
        for (int b = n; b > 1; b--)
        {
            Console.Write("{0} ", n- b + 1);
        }
        Console.WriteLine();
    }

    private static void PrintRow(int i)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("{0} ", j + 1);
        }
        Console.WriteLine();
    }
}

