using System;

class PointCircle
{
    static void Main()
    {
        Console.WriteLine("x= ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("y= ");
        float y = float.Parse(Console.ReadLine());
        float distance = (float)Math.Sqrt (x * x + y* y);
        Console.WriteLine((distance<= 2) ? "The point is in the circle" : "The point is not in the circle");
    }
}

