using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        bool result = (number % 10 == 7);
        Console.WriteLine(result);
    }
}

