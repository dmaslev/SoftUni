using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pairs
{
    static void Main()
    {
        int maxDiff = 0;
        bool isEqual = false;
        string nums = Console.ReadLine();
        string[] splitNums = nums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int value = int.Parse(splitNums[0]) + int.Parse(splitNums[1]);
            
        for (int i = 2; i < splitNums.Length - 1  ; i+=2)
        {
            if (int.Parse(splitNums[i]) + int.Parse(splitNums[i + 1]) == value)

            {
                isEqual = true;
            }

            else
            {
                if (i ==2)
                {
                    maxDiff = Math.Max(maxDiff, Math.Abs(value - (int.Parse(splitNums[i]) + int.Parse(splitNums[i + 1]))));

                }
                else
                {
                    maxDiff = Math.Max(maxDiff, Math.Abs((int.Parse(splitNums[i-2]) + int.Parse(splitNums[i -1]) - (int.Parse(splitNums[i]) + int.Parse(splitNums[i + 1])))));

                }
	
                
            }
        }
        if (isEqual || splitNums.Length==2)
        {
            Console.WriteLine("Yes, value={0}", value);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff );
        }

    }
}

