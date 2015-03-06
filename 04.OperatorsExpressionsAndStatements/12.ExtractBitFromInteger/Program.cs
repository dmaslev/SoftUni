using System;

class Program
{
    static void Main()
    {
        Console.Write("Number = ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Index p = ");
        int p = int.Parse(Console.ReadLine());
        int mask = num >> p;
        Console.WriteLine((num & mask) == 0 ? "bit = 0" : "bit = 1");

    }
}

