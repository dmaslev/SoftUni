using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int n =  int.Parse(Console.ReadLine());
        Console.WriteLine(IsLargerThanNeighbours(numbers, n));
    }

    static bool IsLargerThanNeighbours(int[] numbers, int p)
    {
        int nextNumber = 0;
        if (p == numbers.Length -1)
        {
            nextNumber = int.MinValue;
        }
        else
        {
            nextNumber = numbers[p + 1];

        }
        if (numbers[p] > nextNumber &&
            numbers[p] > numbers[p-1])
        {
            return true;
        }
        return false;
    }
}

