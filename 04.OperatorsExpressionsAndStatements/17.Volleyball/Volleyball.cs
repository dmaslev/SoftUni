using System;

class Volleyball
{
    static void Main()
    {
        string isLeap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double result = 2.0 / 3.0 * p + (48.0 - h) * 3.0 / 4.0 + h;
        if (isLeap=="leap")
        {
            result = result * 1.15;
        }
        Console.WriteLine((int)result);

    }
}

