using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseNumbers
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine("{0:0.##}", GetReversedNumber(number));
    }

    static double GetReversedNumber(string n)
    {
        string result = string.Empty;
        for (int i = 0; i < n.Length; i++)
        {
            result = result + n[n.Length - 1 - i];
        }
        return double.Parse( result);
    }
}

