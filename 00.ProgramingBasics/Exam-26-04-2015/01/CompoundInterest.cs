using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompoundInterest
{
    static void Main()
    {
        double p = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());
        double bank = Math.Pow((1 + i), n);
        bank = bank * p;
        double friend = p + p * f;


        if (bank < friend)
        {
            Console.WriteLine("{0:f2} Bank", bank);
        }
        else
        {
            Console.WriteLine("{0:f2} Friend", friend);
        }

        

        
    }
}

