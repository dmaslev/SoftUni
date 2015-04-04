using System;

class Program
{
    static void Main()
    {
        Console.Write("Please choose a type: ");
        int input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            Console.Write("Please enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number+1);

        }
        else if (input == 2)
        {
            Console.Write("Please enter an double number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(number+1);

        }
        else
        {
            Console.Write("Please enter a string: ");
            string number = Console.ReadLine();
            Console.WriteLine(number + "*");

        }
        
    }
}

