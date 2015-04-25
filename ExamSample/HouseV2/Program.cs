using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(("*".PadLeft(10 - i, '-')).PadRight(19- 2* i, '-'));

        }
    }
}

