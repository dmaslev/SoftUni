using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int lastNumber = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = firstNumber; i <= lastNumber; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                Console.Write("{0} ",i);
            }
         }
        Console.WriteLine();
        Console.WriteLine("p = {0}", p);
        

    }
}

