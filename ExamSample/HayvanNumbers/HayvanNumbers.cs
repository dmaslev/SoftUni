using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int count = 0;

        for (int num1 = 555; num1 <= 999; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;
            long summNumber = 0;
            string result = num1.ToString() + num2 + num3;
            long number = long.Parse(result);
            if (result.Contains("0") || result.Contains("1") || result.Contains("2")|| result.Contains("3")||result.Contains("4"))
            {
                continue;
            }
            for (int i = 0; i < 9; i++)
            {
                summNumber += number % 10;
                number /= 10;

            }
            if (sum ==summNumber)
            {
                Console.WriteLine(result);
                count++;
            }
            
        }
        if (count ==0)
        {
            Console.WriteLine("No");
        }

    }
}

