﻿using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.Clear();
        for (int i = 1; i <= num; i++)
            Console.WriteLine(i);

    }
}

