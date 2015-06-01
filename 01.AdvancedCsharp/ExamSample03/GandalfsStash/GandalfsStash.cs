using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class GandalfsStash
{
    static void Main()
    {
        int happiness = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        string pattern = @"[^a-zA-Z0-9]+";
        Regex regex = new Regex(pattern);
        string[] food = Regex.Split(text, pattern);

        
        for (int i = 0; i < food.Length; i++)
        {
            if (food[i] == "")
            {
                continue;
            }
            switch (food[i].ToLower())
            {
                case "cram": happiness += 2; break;
                case "lembas": happiness += 3; break;
                case "apple": happiness += 1; break;
                case "melon": happiness += 1; break;
                case "honeycake": happiness += 5; break;
                case "mushrooms": happiness -= 10; break;
                default: happiness -=1;
                    break;
            }
        }
        Console.WriteLine(happiness);
        string mood = string.Empty;
        if (happiness < -5)
        {
            mood = "Angry";
        }
        else if (happiness >= -5 && happiness < 0 )
        {
            mood = "Sad";
        }
        else if (happiness >= 0 && happiness < 15)
        {
            mood = "Happy";
        }
        else
        {
            mood = "Special JavaScript mood";
        }
        Console.WriteLine(mood);
    }
}

