using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        int[] numberrs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Array.Sort(numberrs);
        int target = int.Parse(Console.ReadLine());
        int min = 0;
        int max = numberrs.Length - 1;
        int mid = 0;
        int print = -1;
        while (max - min >= 1)
        {
            mid = (max - min )/ 2 + min;

            if (numberrs[mid] == target)
            {
                print = mid;
                
                min = 0;
                max = mid;
                
            }
            else if (numberrs[mid] < target)
            {
                min = mid;
                if (max-min ==1)
                {
                    break;
                }
                continue;
            }
            else if ((numberrs[mid] > target))
            {
                max = mid;
                if (max - min == 1)
                {
                    break;
                }
                
                continue;
            }
        }
        Console.WriteLine(print);
        //Console.WriteLine(-1);

    }
}

