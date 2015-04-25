using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        string t = Console.ReadLine();
        double totalPower = 0;
        
        DateTime time = DateTime.Parse(t);

        if (time.Hour >= 14 && time.Hour <19 )
        {
            totalPower = floors * flats* (2 * 100.53 + 2 * 125.90);
        }
        else if (time.Hour >= 19 && time.Hour <24)
        {
            totalPower = floors * flats * (7 * 100.53 + 6 * 125.90);

        }
        else if (time.Hour >= 0 && time.Hour <9)
        {
            totalPower = floors * flats * (1 * 100.53 + 8 * 125.90);
        }
        else
        {
            totalPower = 0;
        }
        Console.WriteLine("{0} Watts", (int)totalPower);

    }
}

