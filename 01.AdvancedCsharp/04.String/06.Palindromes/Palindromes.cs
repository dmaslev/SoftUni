using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Palindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();
        foreach (var word in words)
        {
            string firstHalf = word.Substring(0, word.Length / 2);
            string secondHalf = word.Substring((word.Length +1) / 2);
            if (firstHalf == new string(secondHalf.Reverse().ToArray()))
            {
                result.Add(word);
            }
        }
        result.Sort();
        Console.WriteLine(string.Join(", ", result));
    }
}

