using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        if (v == 0)
        {
            Console.WriteLine(num & ~(1<<position));
        }
        else
        {
            Console.WriteLine(num | mask);
        }
    }
}

