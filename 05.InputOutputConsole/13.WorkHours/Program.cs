using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int productivity = int.Parse(Console.ReadLine());
        double workHours = 0.9 * days * 12;
        double efficient = workHours * productivity / 100;
        if (h > efficient)
        {
            Console.WriteLine("No");
            Console.WriteLine((int)efficient-h);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine((int)efficient-h);
        }
    }
}

