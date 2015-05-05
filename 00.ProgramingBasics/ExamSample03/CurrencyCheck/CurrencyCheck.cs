using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CurrencyCheck
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        r = r / 100 * 3.5;
        d = d * 1.5;
        e = e * 1.95;
        b = b / 2;
        double result = Math.Min(r, d);
        result = Math.Min(result, e);
        result = Math.Min(result, b);
        result = Math.Min(result, m);
        Console.WriteLine("{0:F2}", result);
    }
}

