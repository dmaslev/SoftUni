using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool isEqual = false;
        if (Math.Abs(firstNumber - secondNumber) >= eps)
        {
            Console.WriteLine("First number = secound number: {0}", isEqual);
        }
        else
        {
            isEqual = true;
            Console.WriteLine("First number = second number: {0}", isEqual);
        }
    }
}

