using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class TheNumbers
{
    static void Main()
    {
        List<string> result = new List<string>();
        string input = Console.ReadLine();
        string pattern = @"\d+";
        Regex regex = new Regex(pattern);

        MatchCollection mathes = regex.Matches(input);
        foreach (Match match in mathes)
        {
            int decValue = int.Parse(match.ToString()); 
            string hexValue = decValue.ToString("X").ToUpper();
            result.Add(string.Format("0x{0}", hexValue.PadLeft(4, '0')));
        }
        Console.WriteLine(string.Join("-", result));
    }
}

