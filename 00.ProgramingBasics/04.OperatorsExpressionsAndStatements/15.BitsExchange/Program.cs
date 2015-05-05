using System;


class Program
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        uint rightBits = num & (7 << 3);
        uint leftBits = num & (7 << 24);
        num = num & ~(56 | (uint)117440512);
        uint result = num | (rightBits << 21) | (leftBits>>21);
        Console.WriteLine(Convert.ToString(result,2).PadLeft(32,'0'));
        Console.WriteLine(result);


    }
}

