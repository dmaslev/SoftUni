using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class TrailingZeroesInN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int countZero = 0;

        for (int i = 5; i <= n; i += 5)
        {
            int number = i;
            while (number % 5 ==0)
            {
                countZero++;
                number = number / 5;
            }
        }
        Console.WriteLine(countZero);

    }
}

