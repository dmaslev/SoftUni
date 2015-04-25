using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inp = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[inp.Length];
        for (int i = 0; i < inp.Length; i++)
        {
            numbers[i] = int.Parse(inp[i]);
        }

        int startIndex = 0;
        int maxCount = 1;
        int counter = 1;

        for (int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i] <= numbers[i+1])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

