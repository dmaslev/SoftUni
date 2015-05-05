using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggestTriple
{
    static void Main()
    {
        string nums = Console.ReadLine();
        string[] splitNums = nums.Split(' ');
        int[] numbers = new int[splitNums.Length];
        numbers = Array.ConvertAll<string, int>(splitNums, int.Parse);
        int sum = int.MinValue;
        string result = string.Empty;


        for (int i = 0; i < numbers.Length; i+=3)
        {
            int tempSum = 0;
            if (numbers.Length -i <2)
            {
                tempSum = numbers[i];
                if (tempSum> sum)
                {
                    sum = tempSum;
                    result = numbers[i].ToString();
                }
                break;
            }
            else if (numbers.Length -i <3)
            {
                tempSum = numbers[i] + numbers[i + 1];
                if (tempSum>sum)
                {
                    result = numbers[i].ToString() + " " + numbers[i + 1];
                }
                break;
            }
            
            tempSum = numbers[i] + numbers[i + 1] + numbers[i + 2];
            if (tempSum > sum)
            {
                sum = tempSum;
                result = "" +numbers[i] +" "+ numbers[i + 1] + " "+numbers[i + 2];
            }
        }

        Console.WriteLine(result);

    }
}


