using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersSelectionSort
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] asString = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] number = Array.ConvertAll(asString, int.Parse);
        int minValue = int.MaxValue;
        int temp = 0;
        for (int i = 0; i < number.Length- 1; i++)
        {
            minValue = i;
            for (int j  = i+ 1; j < number.Length; j++)
            {
                if (number[minValue]  > number[j])
                {
                    minValue = j;
                }
                temp = number[minValue];
                number[minValue] = number[i];
                number[i] = temp;
            }
        }
        Console.WriteLine(string.Join(" ", number));
    }
}

