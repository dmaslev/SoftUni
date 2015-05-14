using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length <20)
        {
            input = input + new string('*', 20 - input.Length);
        }
        else
        {
            input = input.Substring(0, 20);
        }
        Console.WriteLine(input);
    }
}

