using System;
using System.Linq;

public class Bridges
{
    public static void Main()
    {
        int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[,] dp = new int[first.Length, second.Length];

        dp[0, 0] = first[0] == second[0] ? 1 : 0;

        for (int col = 1; col < dp.GetLength(1); col++)
        {
            dp[0, col] = dp[0, col - 1];
            if (first[0] == second[col])
            {
                dp[0, col]++;
            }
        }

        for (int row = 1; row < dp.GetLength(0); row++)
        {
            dp[row, 0] = dp[row - 1, 0];
            if (first[row] == second[0])
            {
                dp[row, 0]++;
            }
        }

        for (int row = 1; row < dp.GetLength(0); row++)
        {
            for (int col = 1; col < dp.GetLength(1); col++)
            {
                dp[row, col] = Math.Max(dp[row - 1, col], dp[row, col - 1]);

                if (first[row] == second[col])
                {
                    dp[row, col]++;
                }
            }
        }

        Console.WriteLine(dp[dp.GetLength(0)-1, dp.GetLength(1)-1]);
    }
}
