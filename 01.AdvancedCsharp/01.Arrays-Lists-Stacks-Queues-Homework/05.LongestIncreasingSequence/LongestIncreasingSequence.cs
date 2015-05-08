using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split().Select(int.Parse).ToArray();
        int startIndex = 0;
        int currentCount = 1;
        int maxCount = 1;
        
        List<int> current = new List<int>();
        current.Add(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i-1])
            {
                current.Add(numbers[i]);
                currentCount++;
            }
            else
            {
                current.ForEach(n => Console.Write("{0} ", n));
                Console.WriteLine();                
                current.Clear();
                current.Add(numbers[i]);
                currentCount = 1;
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                startIndex = i- maxCount + 1;
            }
        }
        
        current.ForEach(n => Console.Write("{0} ", n));
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int i = startIndex; i < startIndex + maxCount; i++)
        {
            Console.Write("{0} ", numbers[i]);

        }
        Console.WriteLine();
    }
}

