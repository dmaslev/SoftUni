using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("Number = ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Index p = ");
        int position = int.Parse(Console.ReadLine());
        int mask = num >> position;
        bool result = (mask & 1) == 1;
        Console.WriteLine("The bit at position {0} is 1: {1}", position, result);
    }
}

