using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Weight: ");
        float weigh = float.Parse(Console.ReadLine());
        Console.WriteLine("Height: ");
        float  height = float.Parse(Console.ReadLine());
        float perimeter = 2 * weigh + 2 * height;
        float area = weigh * height;
        Console.WriteLine("Petimeter: {0}, Area: {1}", perimeter, area);
    }
}

