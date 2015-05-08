using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] first = new int[n][];
        int[][] second = new int[n][];
        for (int i = 0; i < n; i++)
        {
            first[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        for (int i = 0; i < n; i++)
        {
            second[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Reverse(second[i]);
        }

        bool isEqual = true;
        int rowLength = second[0].Length + first[0].Length;
        int counter = rowLength;
        for (int i = 1; i < n; i++)
        {
            if (first[i].Length + second[i].Length != rowLength)
            {
                isEqual = false;
            }
            counter += first[i].Length + second[i].Length;
        }

        if (!isEqual)
        {
            Console.WriteLine("The total number of cells is: {0}", counter);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                foreach (var number in first[i])
                {
                    Console.Write("{0}, ", number);
                }
                for (int j = 0; j < second[i].Length; j++)
                {
                    if (j != second[i].Length - 1)
                    {
                        Console.Write("{0}, ", second[i][j]);
                    }
                    else
                    {
                        Console.Write("{0}]", second[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }

       

    }
}

