﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('.', n / 2));
        Console.Write(new string('#', n));
        Console.WriteLine(new string('.', n / 2));
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', n / 2));
            Console.Write("#");
            Console.Write(new string('.', n- 2));
            Console.Write("#");
            Console.WriteLine(new string('.', n / 2));

        }
        Console.Write(new string('#', n / 2 + 1));
        Console.Write(new string('.', n - 2));
        Console.WriteLine(new string('#', n / 2 + 1));
        for (int i = 1; i < n-1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write("#");
            Console.Write(new string('.', 2*n - 3 - 2 * i));
            Console.Write("#");
            Console.WriteLine(new string('.', i));

        }
        Console.Write(new string('.', (n/2)*2 ));
        Console.Write("#");
        Console.WriteLine(new string('.', (n / 2) * 2));


    }
}

