using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)
        {
            Console.WriteLine("Invalid input!!!");
        }
            
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("|{0, -10:X}|{3, 10}|{1, 10:F2}|{2, -10:F3}|", a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));

    }
}

