using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ReplaceTag
{
    static void Main()
    {
        
        string text = Console.ReadLine();
        string pattern = @"<a( href=[^>]+)>([^<]+)<\/a>";
        Regex regex = new Regex(pattern);
        string result = regex.Replace(text, "[URL$1]$2[/URL]");
        Console.WriteLine(result);
    }
}

