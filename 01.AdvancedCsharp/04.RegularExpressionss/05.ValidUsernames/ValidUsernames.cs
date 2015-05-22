using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ValidUsernames
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<=\s|^|\/|\\|\(|\))[a-zA-Z]\w{2,24}\b";
        Regex regex = new Regex(pattern);
        
        MatchCollection match = regex.Matches(input);
        int maxLenghtIndex = 0;
        int currentLenght = 0;
        int maxLenght = 0;
        for (int i = 0; i < match.Count -1; i++)
        {
            currentLenght = match[i].Length + match[i + 1].Length;
            if (currentLenght > maxLenght)
            {
                maxLenght = currentLenght;
                maxLenghtIndex = i;
            }
        }
        Console.WriteLine(match[maxLenghtIndex]);
        Console.WriteLine(match[maxLenghtIndex+1]);
    }
}

