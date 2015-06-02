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
        Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();
        Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
        string[] array = new string[2];
        string input = Console.ReadLine();
        while (input != "report")
        {
            input = Regex.Replace(input, @"\s+", " ");
            array = input.Split('|');
            string country = array[1].Trim();
            string participant = array[0].Trim();

            if (!dict.ContainsKey(country))
            {
                dict[country] = new HashSet<string>();
                dict2[country] = new List<string>();
            }
            
                dict[country].Add(participant);
                dict2[country].Add(participant);
            
            input = Console.ReadLine();
        }
        var ordered = dict2.OrderByDescending(x => x.Value.Count);

        foreach (var pair in ordered)
        {
            Console.WriteLine("{0} ({1} participants): {2} wins", pair.Key, dict[pair.Key].Count, pair.Value.Count);
        }
    }
}

