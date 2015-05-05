using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string left = new string('*', 2 * n);
        string mid = new string(' ', n);
        string firstLine = left + mid + left;
        Console.WriteLine(firstLine);
        for (int i = 1; i <= n - 2; i++)
        {
           
            string lenses = new string('/', 2 * n - 2);
            Console.Write('*' + lenses + '*');
            Console.Write(mid);
            Console.WriteLine('*' + lenses + '*');
            if (i == (n - 2) / 2)
            {
                mid = new string('|', n);
            }
            else
            {
                mid = new string(' ', n);
            }


        }
        Console.WriteLine(firstLine);
    }
}

