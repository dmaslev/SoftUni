using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LettersChangeNumbers
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        double currentNumber = 0;
        char firstLetter = ' ';
        char lastLetter = ';';
        foreach (var word in words)
        {
            currentNumber = int.Parse(word.Substring(1, word.Length - 2));
            firstLetter = word[0];
            lastLetter = word[word.Length - 1];
            if (firstLetter < 91)
            {
                sum += currentNumber / (firstLetter - 64);
            }
            else
            {
                sum += currentNumber * (firstLetter - 96);
            }
            if (lastLetter < 91)
            {
                sum -= lastLetter - 64;
            }
            else
            {
                sum += lastLetter - 96;
            }
        }
        Console.WriteLine("{0:f2}", sum);
    }
}

