using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        foreach (var ch in input)
        {
            Console.Write("\\u00{0}", Convert.ToString(ch, 16));
        }
        Console.WriteLine();
    }
}

