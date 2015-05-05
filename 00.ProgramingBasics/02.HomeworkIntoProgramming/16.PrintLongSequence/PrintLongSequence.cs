using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1010;
        for (int a = 2; a <= 1001; a++)
            Console.WriteLine((a % 2 ==0) ? a : -a);
    }
}

