using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DifferenceBetweenDates
{
    static void Main()
    {
        CultureInfo bgBG = new CultureInfo("bg-BG");
        Console.Write("First date = ");
        string dateString = Console.ReadLine();
        DateTime first = DateTime.ParseExact(dateString, "d.MM.yyyy", bgBG);
        Console.Write("First date = ");
        dateString = Console.ReadLine();
        DateTime second = DateTime.ParseExact(dateString, "d.MM.yyyy", bgBG);

        TimeSpan span = second - first;

        Console.WriteLine(span.TotalDays);

    }
}

