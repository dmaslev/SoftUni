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

        for (int i = 1; i < numberrs.Length; i++)
        {
            if (numberrs[i-1] > numberrs[i])
            {
                int temp = numberrs[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    while (numberrs[j] > temp)
                    {
                        numberrs[j+1] = numberrs[j];
                        numberrs[j] = temp;

                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", numberrs ));

    }
}

