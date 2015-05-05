using System;

class Program
{
    static void Main()
    {
        Console.Write("Radius: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter: {0:F2}", Math.PI * 2* r );
        Console.WriteLine("Area: {0:F2}", Math.PI * r * r);
    }
}

