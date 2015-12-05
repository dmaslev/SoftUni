using System;
using System.Linq;
using System.Numerics;

class Election
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int summ = numbers.Sum();
        BigInteger[] dp = new BigInteger[summ + 1];
        dp[0] = 1;
        var maxSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = summ; j >=0; j--)
            {
                if (dp[j] >0)
                {
                    dp[j + numbers[i]] += dp[j];
                    maxSum = Math.Max(maxSum, j + numbers[i]);
                }
            }
        }

        BigInteger count = 0;
        for (int i = k; i < dp.Length; i++)
        {
            if (dp[i] > 0)
            {
                count += dp[i];
            }
        }
        Console.WriteLine(count);
    }
}