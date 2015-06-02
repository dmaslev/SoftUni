using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        List<string> result = new List<string>();
        while (line != "burp")
        {
            sb.Append(line);
            line = Console.ReadLine();
        }
        Regex repla = new Regex(@"\s+");
        string word = sb.ToString();
        word = repla.Replace(word, " ");
        string patter = @"([$%&'])([^$%&']+)\1";
        Regex regex = new Regex(patter);
        MatchCollection matches = regex.Matches(word);

        int weight = 0;
        
        foreach (Match match in matches)
        {
            char current;
            StringBuilder print = new StringBuilder();
            string curren = match.Value.ToString();
            
            switch (curren[0])
            {
                case '$': weight = 1; break;
                case '%': weight = 2; break;
                case '&': weight = 3; break;
                case '\'': weight = 4; break;
                default: weight = 4; break;
                    
            }
            for (int i = 1; i < curren.Length-1; i++)
            {
                if (i % 2 ==1)
                {
                    current = (char)(curren[i] + weight);
                    print.Append(current); 
                }
                else
                {
                    current = (char)(curren[i] - weight);
                    print.Append(current);
                }
            }
            result.Add(print.ToString());
        }
        Console.WriteLine(string.Join(" ", result));
    }
}

