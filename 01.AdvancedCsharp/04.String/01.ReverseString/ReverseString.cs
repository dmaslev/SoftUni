using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        var result = input.ToCharArray();
        string a = string.Empty;
        Array.Reverse(result);
        Console.WriteLine(string.Join("", result));
    }
}

