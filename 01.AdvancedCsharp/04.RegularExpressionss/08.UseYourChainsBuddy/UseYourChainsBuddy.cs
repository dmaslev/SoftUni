using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class UseYourChainsBuddy
{
    static void Main()
    {
        string result = string.Empty;
        string input = Console.ReadLine();
        string pattern = @"(?<=<p>).+?(?=<\/p>)";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        string print = string.Empty;

        foreach (Match match in matches)
        {
            result = Regex.Replace(match.ToString(), @"[^a-z0-9]+", " ");
            result = Regex.Replace(result, @"\s+", " ");
            foreach (var ch in result)
            {
                if (ch >96 && ch < 110)
                {
                    print += (char)(ch + 13);
                }
                else if (ch > 109 && ch <123)
                {
                    print += (char)(ch - 13);
                }
                else
                {
                    print += ch;
                }
            }
        }
        Console.Write(print);
        

    }
}

