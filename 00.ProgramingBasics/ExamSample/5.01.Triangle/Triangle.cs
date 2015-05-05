
using System;

class Triangle
{
    static void Main()
    {
        int ax = int.Parse(Console.ReadLine());
        int ay = int.Parse(Console.ReadLine());
        int bx = int.Parse(Console.ReadLine());
        int by = int.Parse(Console.ReadLine());
        int cx = int.Parse(Console.ReadLine());
        int cy = int.Parse(Console.ReadLine());
        double a = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
        double b = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));
        double c = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
        if (a+b>c &&  b+c> a & a+c >b)
        {
            Console.WriteLine("Yes");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0:f2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:f2}",c);
            

        }

    }
}

