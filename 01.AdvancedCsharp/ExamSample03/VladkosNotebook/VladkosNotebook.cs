using System;
using System.Collections.Generic;

class VladkosNotebook
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, dynamic>> notebook
            = new SortedDictionary<string, Dictionary<string, dynamic>>();

        string line = Console.ReadLine();
        while (line != "END")
        {
            string[] items = line.Split('|');
            string color = items[0];
            string property = items[1];
            string value = items[2];
            if (!notebook.ContainsKey(color))
            {
                Dictionary<string, dynamic> player =
                    new Dictionary<string, dynamic>();
                notebook[color] = player;
                notebook[color]["win"] = 0;
                notebook[color]["loss"] = 0;
            }

            if (property == "age")
                notebook[color]["age"] = int.Parse(value);
            if (property == "name")
                notebook[color]["name"] = value;

            if (property == "win" || property == "loss")
            {
                if (!notebook[color].ContainsKey("opponents"))
                {
                    List<string> opponents = new List<string>();
                    notebook[color]["opponents"] = opponents;
                }
                notebook[color]["opponents"].Add(value);
                if (property == "win")
                    notebook[color]["win"]++;
                else
                    notebook[color]["loss"]++;

            }

            line = Console.ReadLine();

        }

        bool found = false;

        foreach (string key in notebook.Keys)
        {
            if (notebook[key].ContainsKey("name") && notebook[key].ContainsKey("age"))
            {
                found = true;
                Console.WriteLine("Color: {0}", key);
                Console.WriteLine("-age: {0}", notebook[key]["age"]);
                Console.WriteLine("-name: {0}", notebook[key]["name"]);

                string opponentsString = "";
                if (!notebook[key].ContainsKey("opponents") || notebook[key]["opponents"].Count == 0)
                {
                    opponentsString = "(empty)";
                }
                else
                {
                    List<string> opponentsList = notebook[key]["opponents"];
                    StringComparer ordCmp = StringComparer.Ordinal;
                    opponentsList.Sort(ordCmp);
                    opponentsString = string.Join(", ", opponentsList);
                }
                Console.WriteLine("-opponents: {0}", opponentsString);

                double rank = (double)(notebook[key]["win"] + 1) / (double)(notebook[key]["loss"] + 1);
                Console.WriteLine("-rank: {0:f2}", rank);
            }
        }
        if (!found)
            Console.WriteLine("No data recovered.");
    }
}