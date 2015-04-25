using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NineDigitMagicNumber
{
    static void Main()
    {
        long sum =  long.Parse(Console.ReadLine());
        long diff = long.Parse(Console.ReadLine());
        string result = string.Empty;
        long counter = 0;
        for (long num1 = 111; num1 <= 777; num1++)
        {
            long summNumber = 0;
            long num2 = num1 + diff;
            long num3 = num2 + diff;
            result = num1.ToString() + num2 + num3;
            if (result.Contains("0") || result.Contains("8") || result.Contains("9"))
            {
                continue;
            }
            long number = long.Parse(result);
            for (long i = 0; i < 9; i++)
            {
                summNumber += number % 10;
                number = number / 10;
            }
            if (sum ==summNumber)
            {
                Console.WriteLine(result);
                counter++;
            }

        }
        if (counter==0)
        {
            Console.WriteLine("No");
        }
    }
}

