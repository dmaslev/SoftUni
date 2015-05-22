using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SentenceExtractor
{
    static void Main()
    {
        string word = Console.ReadLine();
        string input = Console.ReadLine();
        string pattern = @"[A-Z](.*?\b" + Regex.Escape(word) + @"\b.*?[?.!])";
        Regex regex = new Regex(pattern);
        Match match = Regex.Match(input, pattern);
        while (match.Success)
        {
            Console.WriteLine(match);
            match = match.NextMatch();
        }
    }
}

