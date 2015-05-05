using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHecadecimal
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        string hexadecimal = string.Empty;
        long value = 0;

        while (dec > 0)
        {
            value = dec % 16;
            dec /= 16;
            if (value <=9)
            {
                hexadecimal = "" + value + hexadecimal;
            }
            else
            {
                string v = string.Empty;
                switch (value)
                {
                    case 10: v = "A";
                        break;
                    case 11: v = "B";
                        break;
                    case 12: v = "C";
                        break;
                    case 13: v = "D";
                        break;
                    case 14: v = "E";
                        break;
                    case 15: v = "F";
                        break;
                    default:
                        break;
                }
                hexadecimal = "" + v + hexadecimal;
            }
        }
        Console.WriteLine(hexadecimal);

    }
}

