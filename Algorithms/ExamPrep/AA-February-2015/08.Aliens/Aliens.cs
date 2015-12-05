namespace _08.Aliens
{
    using System;
    using System.Linq;

    public class Aliens
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            int[,,] dp = new int[first.Length + 1, second.Length + 1, third.Length + 1];

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    for (int k = 1; k < dp.GetLength(2); k++)
                    {
                        if (first[i - 1] == second[j - 1] && first[i - 1] == third[k - 1])
                        {
                            dp[i, j, k] = dp[i - 1, j - 1, k - 1] + 1;
                        }
                        else if (dp[i - 1, j, k] >= dp[i, j - 1, k] && dp[i - 1, j, k] >= dp[i, j, k - 1])
                        {
                            dp[i, j, k] = dp[i - 1, j, k];
                        }
                        else if (dp[i, j - 1, k] >= dp[i - 1, j, k] && dp[i, j - 1, k] >= dp[i, j, k - 1])
                        {
                            dp[i, j, k] = dp[i, j - 1, k];
                        }
                        else
                        {
                            dp[i, j, k] = dp[i, j, k - 1];
                        }
                    }
                }
            }

            Console.WriteLine(dp[dp.GetLength(0) - 1, dp.GetLength(1) - 1, dp.GetLength(2) - 1]);
        }
    }
}
