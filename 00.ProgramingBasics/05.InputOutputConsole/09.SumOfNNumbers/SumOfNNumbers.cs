using System;

class SumOfNNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i =0; i < num; i++)
        {
            double a = double.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}

