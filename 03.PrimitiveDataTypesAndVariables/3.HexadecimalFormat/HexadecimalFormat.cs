using System;


class FloatOrDouble
{
    static void Main(string[] args)
    {
        int decValue = 0xFE;
        Console.WriteLine(decValue);
        Console.WriteLine("The hecimal mavue of {0} is 0x{1}" ,decValue, Convert.ToString(decValue, 16));
    }
}

