using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class QueryMess
{
    static void Main()
    {
        string input = Console.ReadLine();
        string whiteSpace = @"\s{2,}";
        Regex removeWhiteSpaces = new Regex(whiteSpace);
        string pattern = @"([^=&?]+)=([^&=]+)";
        Regex regex = new Regex(pattern);

        MatchCollection matches;
        Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
        while (input != "END")
        {
            input = input.Replace("%20", " ").Replace("+", " ");
            input = removeWhiteSpaces.Replace(input, " ");
            matches = regex.Matches(input);

            foreach (Match match in matches)
            {

                string field = match.Groups[1].ToString().Trim();
                string value = match.Groups[2].ToString().Trim();
                if (!output.ContainsKey(field))
                {
                    output.Add(field, new List<string>());
                }
                output  [field].Add(value);
            }
            foreach (string field in output.Keys)
            {
                Console.Write("{0}=[{1}]", field, string.Join(", ", output[field]));
            }
            Console.WriteLine();
            output.Clear();
            input = Console.ReadLine();

        }
    }
}

