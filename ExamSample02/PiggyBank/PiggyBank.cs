using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PiggyBank
{
    static void Main()
    {
        int tank = int.Parse(Console.ReadLine());
        int party = int.Parse(Console.ReadLine());
        int profit = (30 - party) * 2;
        int waste = party * 5;
        int months = 0;
        if (waste >= profit)
        {
            Console.WriteLine("never");
        }
        else
        {
            months = tank / (profit - waste);
            if (months * (profit - waste) < tank)
            {
                months++;
            }
            int finalYears = months / 12;
            int finalMonths = months % 12;
            Console.WriteLine("{0} years, {1} months", finalYears, finalMonths);

        }
    }
         
}

