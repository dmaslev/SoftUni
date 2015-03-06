using System;

class FootballPlayer
{
    static void Main()
    {
        string isLeap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double result = h + ((52d - h) * 2d) / 3d + p / 2d;
        if (isLeap == "t")
        {
            result += 3;
        }
        Console.WriteLine((int)result);

    }
}

