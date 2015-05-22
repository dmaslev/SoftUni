using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractEmail
{
    static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"(?<=\s)[a-z0-9]+[\._-]?\w+@\w+[.-][\w\.]+\w+";
        Regex regex = new Regex(pattern);
        MatchCollection match = regex.Matches(input);
        foreach (var item in match)
        {
            Console.WriteLine(item);
        }



    }
}

