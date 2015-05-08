using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsets
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().ToArray();
        bool resultFound = false;
        List<int> currentSubset = new List<int>();
        List<List<int>> result = new List<List<int>>();
        int combinations = (int)Math.Pow(2, numbers.Length);

        for (int i = 1; i < combinations; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    currentSubset.Add(numbers[j]);
                }
            }
            if (currentSubset.Sum() == sum)
            {
                result.Insert(0, new List<int>(currentSubset));
                resultFound = true;
            }
            currentSubset = new List<int>();
        }
        if (!resultFound)
        {
            Console.WriteLine("No matching subsets.");
            return;
        }        
        foreach (var item in result)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", item), sum);
        }

    }
}