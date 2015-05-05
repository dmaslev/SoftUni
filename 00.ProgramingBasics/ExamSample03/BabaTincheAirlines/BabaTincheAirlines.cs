using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BabaTincheAirlines
{
    static void Main()
    {
        string[] firstClass = Console.ReadLine().Split();
        string[] bussinessClass = Console.ReadLine().Split();
        string[] economyClass = Console.ReadLine().Split();
        double income = 0;
        double maxIncome = 12 * 7000.0 + 12 * 7000 * 0.005 +
                           28 * 3500.0 + 28 * 3500 * 0.005 +
                           50 * 1000.0 + 50 * 1000 * 0.005;
        income = int.Parse(firstClass [0]) *7000 + 
                 int.Parse(bussinessClass[0]) * 3500 +
                 int.Parse(economyClass[0]) * 1000;
        income = income - int.Parse(firstClass[1]) * 7000 * 0.7-
                 int.Parse(bussinessClass[1]) * 3500 * 0.7 -
                 int.Parse(economyClass[1]) * 1000 * 0.7;
        income += int.Parse(firstClass[2]) * 7000 * 0.005 +
                  int.Parse(bussinessClass[2]) * 3500 * 0.005 +
                  int.Parse(economyClass[2]) * 1000 * 0.005;

        Console.WriteLine((int)income);
        int diff = (int)maxIncome - (int)income;
        Console.WriteLine(diff);

    }
}

