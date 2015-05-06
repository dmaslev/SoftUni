using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[10, 10];
        int x, y;
        int[,] result = new int[10, 10];
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            arr[x, 9 - y] = 1;
        }
        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k < 10; k++)
            {
                int current = GetValue(i, k, arr);
                int upLeft = GetValue(i - 1, k - 1, arr);
                int up = GetValue(i - 1, k, arr);
                int upRight = GetValue(i - 1, k + 1, arr);
                int left = GetValue(i, k - 1, arr);
                int right = GetValue(i, k + 1, arr);
                int downLeft = GetValue(i + 1, k - 1, arr);
                int down = GetValue(i + 1, k, arr);
                int downRight = GetValue(i + 1, k + 1, arr);
                int[] ones = { up, upLeft, upRight, left, right, down, downLeft, downRight };
                foreach (var item in ones)
                {
                    if (item > 0)
                    {
                        counter++;
                    }
                }
                if (current ==0)
                {
                    if (counter ==3)
                    {
                        result[i, k] = 1;
                    }
                    else
                    {
                        result[i, k] = 0;
                    }
                }

                if (current ==1)
                {
                    if (counter ==2 || counter ==3)
                    {
                        result[i, k] = 1;

                    }
                    else
                    {
                        result[i, k] = 0;
                    }
                }
                counter = 0;

            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k < 10; k++)
            {
                Console.Write(result[i, k]);
            }
            Console.WriteLine();
        }


    }

    private static int GetValue(int a, int b, int[,] arr)
    {
        bool check = IsValid(a, b);
        if (check == false)
        {
            return 0;
        }
        else
        {
            return arr[a, b];
        }
    }

    private static bool IsValid(int a, int b)
    {
        if (a < 0 | a > 9)
        {
            return false;
        }
        else if (b < 0 || b > 9)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

