using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<![a-z])[A-Z]+(?![a-z])";
        Regex regex = new Regex(pattern);
        

        while (input != "END")
        {
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string word = match.Value.ToString();
                string reversed = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    reversed += word[word.Length - i- 1];
                }
                if (word == reversed)
                {
                    reversed = string.Empty;
                    foreach (char ch in word)
                    {
                        reversed += "" +  ch + ch;
                    }
                }
                string pat = @"(?<![a-zA-Z])" + Regex.Escape(word) + @"(?![a-zA-Z])";
                Regex rep = new Regex(pat);

                input = rep.Replace(input, reversed);
            }
            Console.WriteLine(SecurityElement.Escape(input));
            input = Console.ReadLine();
        }
        Console.WriteLine();
    }
}

