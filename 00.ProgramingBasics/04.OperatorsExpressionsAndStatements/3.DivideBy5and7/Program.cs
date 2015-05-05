using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = (number % 5 == 0 && number % 7 == 0 && number != 0 );
        Console.WriteLine(result);
    }
}

