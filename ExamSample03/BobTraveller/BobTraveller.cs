using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BobTraveller
{
    static void Main(string[] args)
    {
        string leap = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());
        double travels = 0;

        travels += contractMonths * 4 * 3;
        travels += familyMonths * 2 * 2;
        travels += (12 - familyMonths - contractMonths) * 12 * (3.0 / 5.0);
        if (leap == "leap")
        {
            travels = travels * 1.05;
        }

        Console.WriteLine((int)travels);
    }
}
