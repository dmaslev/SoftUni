using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinMaxSumAvg
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double avg = 0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            avg = (double)sum / i;
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);

    }
}

