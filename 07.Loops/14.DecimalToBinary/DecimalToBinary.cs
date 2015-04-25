using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Decimal number = ");
        long dec = long.Parse(Console.ReadLine());
        string binary = string.Empty;
        long value = 0;
        while (dec > 0)
        {
            value = dec % 2;
            dec /= 2;
            binary = "" + value + binary;
        }

        Console.WriteLine(binary);
    }
}

