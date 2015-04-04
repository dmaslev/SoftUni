using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DrawFigure
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int ch = n;

        for (int i = 0; i < (n+1)/2; i++)
        {
            string midd = new string('*', ch);
            string left = new string('.', i);
            Console.WriteLine(left + midd + left);
            ch -= 2;
        }
        ch = 3;
        for (int i = 1; i <= n/2; i++)
        {
            string midd = new string('*', ch);
            string left = new string('.', n/2-i);
            Console.WriteLine(left + midd + left);
            ch += 2;
        }
    }
}
