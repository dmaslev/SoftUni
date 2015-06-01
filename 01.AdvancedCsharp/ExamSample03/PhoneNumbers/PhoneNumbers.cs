using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class PhoneNumbers
{
    static void Main()
    {

        Dictionary<string, string> result = new Dictionary<string, string>();
        string pattern = @"([A-Z][a-zA-Z]*)[^a-z+\d]*?(\+?\d+[()\/.\- \d]*\d+)";
        Regex regex = new Regex(pattern);
        string number = string.Empty;
        string text = string.Empty;
        string line = Console.ReadLine();
        while (line != "END")
        {
            text += line;
            line = Console.ReadLine();
        }
        MatchCollection matches = regex.Matches(text);
        foreach (Match m in matches)
        {
            Regex rep = new Regex(@"[^\d\+]");
            number = rep.Replace(m.Groups[2].ToString(), "");
            result[m.Groups[1].ToString()] = number;
        }
        if (result.Count == 0)
        {
            Console.WriteLine("<p>No matches!</p>");
            return;
        }        
        Console.Write("<ol>");
        foreach (var num in result)
        {
            Console.Write("<li><b>{0}:</b> {1}</li>", num.Key, num.Value);
        }
        Console.WriteLine("</ol>");


    }
}

