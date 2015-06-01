using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


class ChatLogger
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        string patter = @"(.+)\s+\/\s+(\d{2}-\d{2}-\d{4} \d{2}:\d{2}:\d{2})";
        Regex regex = new Regex(patter);
        
        string line = Console.ReadLine();
        DateTime currentDate = DateTime.Parse(line);
        line = Console.ReadLine();
        SortedDictionary<DateTime, string> dict = new SortedDictionary<DateTime, string>();
        string input = string.Empty;
        while (line != "END")
        {
            Match match = regex.Match(line);
            string message = match.Groups[1].ToString();
            DateTime date = DateTime.Parse(match.Groups[2].ToString());
            dict[date] = message;
            line = Console.ReadLine();
        }
        DateTime lastDate = dict.Last().Key;
        TimeSpan time = currentDate - lastDate;


        foreach (var couple in dict)
        {
            Console.WriteLine("<div>{0}</div>", SecurityElement.Escape(couple.Value));
        }
        if (lastDate.Day < currentDate.Day - 1)
        {
            Console.WriteLine("<p>Last active: <time>{0}</time></p>", lastDate.ToString("dd-MM-yyyy"));
        }

        else if (lastDate.Day == currentDate.Day - 1)
        {
            Console.WriteLine("<p>Last active: <time>yesterday</time></p>");
        }
        else if (lastDate.Day == currentDate.Day && time.TotalHours >= 1)
        {
            Console.WriteLine("<p>Last active: <time>{0} hour(s) ago</time></p>", (int)time.TotalHours);
        }
        else if (time.TotalHours < 1 && time.TotalMinutes >= 1)
        {
            Console.WriteLine("<p>Last active: <time>{0} minute(s) ago</time></p>", (int)time.TotalMinutes);
        }
        else
        {
            Console.WriteLine("<p>Last active: <time>a few moments ago</time></p>");
        }

    }
}

    