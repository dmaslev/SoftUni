using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        string input =  Console.ReadLine();
        int[] numbers = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Console.WriteLine(ReturnFirstLargerThanNeighbours(numbers));
    }

    static string ReturnFirstLargerThanNeighbours(int[] numbers)
    {
        foreach (var n in numbers)
        {
            int nextNumber = 0;
            if (n == numbers.Length - 1)
            {
                nextNumber = int.MinValue;
            }
            else
            {
                nextNumber = numbers[n + 1];

            }
            if (numbers[n] > nextNumber &&
                numbers[n] > numbers[n - 1])
            {
                return n.ToString();
            }
        }
        return "-1";

        
    }
}

