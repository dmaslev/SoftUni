using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


class NumberCalculations
{
    static void Main()
    {
        Console.WriteLine("Please enter double numbers separated by space:");
        string input = Console.ReadLine();
        string[] set = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        double[] numbers = Array.ConvertAll(set, s => double.Parse(s));
        Console.WriteLine("Minimum: {0}", Minimum(numbers));
        Console.WriteLine("Maximum: {0}", Maximum(numbers));
        Console.WriteLine("Avarage: {0}", Avarage(numbers, Sum(numbers)));
        Console.WriteLine("Sum: {0}", Sum(numbers));
        Console.WriteLine("Product: {0}", Product(numbers));
        Console.WriteLine("Please enter decimal numbers separated by space:");
        string dec = Console.ReadLine();
        string[] stringNumbers = dec.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        decimal[] decimalNumbers = Array.ConvertAll(stringNumbers, s => decimal.Parse(s));
        Console.WriteLine("Minimum: {0}", Minimum(decimalNumbers));
        Console.WriteLine("Maximum: {0}", Maximum(decimalNumbers));
        Console.WriteLine("Avarage: {0}", Avarage(decimalNumbers, Sum(decimalNumbers)));
        Console.WriteLine("Sum: {0}", Sum(decimalNumbers));
        Console.WriteLine("Product: {0}", Product(decimalNumbers));



    }
    static decimal Product(decimal[] numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    static decimal Sum(decimal[] numbers)
    {
        decimal sum = 0;
        foreach (var n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    static decimal Avarage(decimal[] numbers, decimal sum)
    {

        decimal avarage = sum / numbers.Length;
        return avarage;
    }

    static decimal Maximum(decimal[] numbers)
    {
        decimal max = decimal.MinValue;
        foreach (var n in numbers)
        {
            if (max < n)
            {
                max = n;
            }
        }
        return max;
    }

    static decimal Minimum(decimal[] numbers)
    {
        decimal min = decimal.MaxValue;
        foreach (var n in numbers)
        {
            if (min > n)
            {
                min = n;
            }
        }
        return min;
    }
    
    static double Product(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    static double Sum(double[] numbers)
    {
        double sum = 0;
        foreach (var n in numbers)
        {
            sum += n;
        }
        return sum;
    }

    static double Avarage(double[] numbers, double sum)
    {
        
        double avarage = sum / numbers.Length;
        return avarage;
    }

    static double Maximum(double[] numbers)
    {
        double max = double.MinValue;
        foreach (var n in numbers)
        {
            if (max < n)
            {
                max = n;
            }
        }
        return max;
    }

    static double Minimum(double[] numbers)
    {
        double min = double.MaxValue;
        foreach (var n in numbers)
        {
            if (min > n)
            {
                min = n;
            }
        }
        return min;
    }
}

