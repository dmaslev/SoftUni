using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int summEven = 0;
        for (int i = 0; i < 2 *n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 1)
            {
                sumOdd += number;
            }
            else
            {
                summEven += number;
            }
        }
        if (sumOdd == summEven)
        {
            Console.WriteLine("Yes, sum={0}", summEven);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(summEven-sumOdd));
        }
    }
}

