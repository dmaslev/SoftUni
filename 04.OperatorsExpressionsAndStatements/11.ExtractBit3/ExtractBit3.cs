using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint num = uint.Parse(Console.ReadLine());
        uint a = num << 3;
        Console.WriteLine((num & a) == 0 ? "The third bit is 0" : " The third bit is 1");

    }
}

