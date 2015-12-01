namespace _01.BinomialCoefficients
{
    using System;

    class BinomialCoefficients
    {
        private static int[,] memo;

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            memo = new int[n + 1, k + 1];

            Console.WriteLine(CalculateBinaryCoefficient(n, k));
        }

        private static int CalculateBinaryCoefficient(int n, int k)
        {
            if (memo[n, k] != 0)
            {
                return memo[n, k];
            }

            if (k == 0 || k == n)
            {
                return 1;
            }

            memo[n, k] = CalculateBinaryCoefficient(n - 1, k - 1) + CalculateBinaryCoefficient(n - 1, k);
            return memo[n, k];
        }
    }
}