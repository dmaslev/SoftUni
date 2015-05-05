using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string rightDots = new string('.', n);
        for (int i = 0; i < n/2 +1; i++)
        {
            string left = new string('.', n - 1 - 2 * i);
            string asp = new string('*', 1 + 2 * i);
            Console.WriteLine(left+asp+rightDots);
        }
        for (int k = 0; k < n/2; k++)
        {
            string leftDots = new string('.', 2 + 2 * k);
            string ch = new string('*', n-2 - 2*k);
            Console.WriteLine(leftDots + ch+ rightDots);
        }
        for (int b = 0; b < n/2; b++)
        {
            string dots = new string('.', b);
            string bottom = new string('*', 2 * n - 2 * b);
            Console.WriteLine(dots+bottom+dots);
        }
    }
}

