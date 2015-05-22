using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"(\w)\1+";
        Regex regex = new Regex(pattern);
        string result = regex.Replace(text, "$1");
        Console.WriteLine(result);
    }
}

