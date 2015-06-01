using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SumOfAllValues
{
    static void Main()
    {
        string keysString = Console.ReadLine();
        string textString = Console.ReadLine();
        string pattern = @"^([a-zA-Z_]+)(?=\d)";
        string endPatter = @"(?<=\d)([a-zA-Z_]+)$";
        string startKey = Regex.Match(keysString, pattern).ToString();
        string endKey = Regex.Match(keysString, endPatter).ToString();
        double sum = 0;
        if (startKey.Length == 0 || endKey.Length == 0)
        {
            Console.WriteLine("<p>A key is missing</p>");
            return;
        }
        string numPat = startKey + @"(.?\d+[.\d]*)" + endKey;
        Regex regex = new Regex(numPat);

        MatchCollection matches = regex.Matches(textString);
        foreach (Match match in matches)
        {
            sum += double.Parse(match.Groups[1].ToString());
        }
        if (sum ==0)
        {
            Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
        }
        else
        {
            Console.WriteLine("<p>The total value is: <em>{0}</em></p>", sum);
        }

    }
}

