using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfElements
{
    static void Main()
    {
        string nums = Console.ReadLine();
        string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        long sum = 0;
        long maxValue = long.MinValue;
        for (int i = 0; i < splitNums.Length; i++)
        {
            sum = sum + long.Parse(splitNums[i]);
            if (long.Parse( splitNums[i]) > maxValue)
            {
                maxValue = long.Parse(splitNums[i]);
            }
            
        }
        if (maxValue * 2 == sum)
        {
            Console.WriteLine("Yes, sum={0}", maxValue);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(maxValue - (sum - maxValue)));
        }
        

    }
}

