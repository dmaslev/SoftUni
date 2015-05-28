using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OfficeStuff
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        SortedDictionary<string, Dictionary<string, int>> office = new SortedDictionary<string, Dictionary<string, int>>();
        string[] current = new string[3];
        for (int i = 0; i < a; i++)
        {
            string line = Console.ReadLine();
            current = line.Split(new char[] { '|', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string company = current[0].Substring(0, current[0].Length-1);
            string product = current[2].Substring(1);
            int amount = int.Parse(current[1]);
            if (office.ContainsKey(company))
            {
                if (office[company].ContainsKey(product))
                {
                    office[company][product] += amount;
                }
                else
                {
                    office[company].Add(product, amount);
                }
            }
            else
            {
                office[company] = new Dictionary<string, int>();
                office[company].Add(product, amount);
            }

        }
        office.OrderBy(x => x.Key);
        foreach (var pair in office)
        {
            Console.Write("{0}: ", pair.Key);

            bool print = false;
            foreach (var name in pair.Value)
            {
                if (print == true)
                {
                    Console.Write(", ");
                }
                print = true;
                Console.Write("{0}-{1}", name.Key, name.Value);

            }
            Console.WriteLine();
        }
        
    }
}

