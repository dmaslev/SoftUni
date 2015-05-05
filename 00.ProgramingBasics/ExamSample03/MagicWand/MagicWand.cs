using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string dots = new string('.', 3 * n / 2 + 1);
        Console.WriteLine("{0}*{0}", dots);
        for (int i = 0; i < n/2 + 1; i++)
        {
            string leftDots = new string('.', n + n / 2 - i);
            string middleDots = new string('.', 1 + 2 * i);
            Console.WriteLine("{0}*{1}*{0}", leftDots , middleDots);
        }
        Console.WriteLine(new string('*', n) + new string ('.', n+ 2) + new string('*',n));
        for (int i = 0; i < n/2; i++)
        {
            string left = new string('.', 1 + i);
            string middle = new string('.', 3 * n - 2 - 2 * i);
            Console.WriteLine("{0}*{1}*{0}", left, middle);
        }
        string middlePart = new string('.', n);

        for (int i = 0; i < n/2; i++)
        {
            string first = new string('.', n/2 - 1 - i);
            string second = new string('.', n/2);
            string third = new string('.',  i);
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", first, second, third, middlePart);
        }
        string leftPart = new string('*', 1 + n / 2);
        string rightPart = new string('.', n / 2);
        Console.WriteLine("{0}{1}*{2}*{1}{0}", leftPart, rightPart, middlePart);
        leftPart = new string('.', n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", leftPart);
        }
        Console.WriteLine("{0}*{1}*{0}", leftPart, new string('*', n));
    }
}

