using System;

class PrintASequence
{
    static void Main()
    {
        for (int a = 2; a < 12; a++ )
            Console.WriteLine((a % 2 == 0) ? a : -a);
    }
}

