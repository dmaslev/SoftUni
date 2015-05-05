using System;

class NumberComaprer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = Math.Max(a, b);
        Console.WriteLine("Greater: {0}", c);
    }
}

