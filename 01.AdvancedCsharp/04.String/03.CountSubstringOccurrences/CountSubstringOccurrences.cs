using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSubstringOccurrences
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string matchWord = Console.ReadLine().ToLower();
        int counter = 0;
        int index = input.IndexOf(matchWord);

        while (index != - 1)
        {
            counter++;
            index = input.IndexOf(matchWord, index + 1);
        }
        Console.WriteLine(counter);
    }
}

