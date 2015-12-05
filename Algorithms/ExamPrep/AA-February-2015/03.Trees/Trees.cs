using System;

public class Trees
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        var dp = new long[11, 11, 11, 11, 5];

        dp[0, 0, 0, 0, 0] = 1;
        dp[0, 0, 0, 0, 1] = 1;
        dp[0, 0, 0, 0, 2] = 1;
        dp[0, 0, 0, 0, 3] = 1;

        for (int i = 0; i <= a; i++)
        {
            for (int j = 0; j <= b; j++)
            {
                for (int k = 0; k <= c; k++)
                {
                    for (int l = 0; l <= d; l++)
                    {
                        if (i > 0)
                        {
                            dp[i, j, k, l, 0] = dp[i - 1, j, k, l, 1] + dp[i - 1, j, k, l, 2] + dp[i - 1, j, k, l, 3];
                        }

                        if (j > 0)
                        {
                            dp[i, j, k, l, 1] = dp[i, j - 1, k, l, 0] + dp[i, j - 1, k, l, 2] + dp[i, j - 1, k, l, 3];
                        }

                        if (k > 0)
                        {
                            dp[i, j, k, l, 2] = dp[i, j, k - 1, l, 0] + dp[i, j, k - 1, l, 1] + dp[i, j, k - 1, l, 3];
                        }

                        if (l > 0)
                        {
                            dp[i, j, k, l, 3] = dp[i, j, k, l - 1, 0] + dp[i, j, k, l - 1, 1] + dp[i, j, k, l - 1, 2];
                        }
                    }
                }
            }
        }

        Console.WriteLine((dp[a, b, c, d, 0] + dp[a, b, c, d, 1] + dp[a, b, c, d, 2] + dp[a, b, c, d, 3]) / 3);
    }
}