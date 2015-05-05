using System;

class SumOf5Nums
{
    static void Main()
    {
        //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

        Console.WriteLine("Please enter a five numbers separated by a space:");
        string nums = Console.ReadLine();
        string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < splitNums.Length; i++)
        {
            sum = sum + double.Parse(splitNums[i]);
        }
        Console.WriteLine(sum);
    }
}