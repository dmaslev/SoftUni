namespace _03.DividingPresents
{
    using System;
    using System.Linq;

    class DividingPresents
    {
        static void Main()
        {
            var allNumbers = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = allNumbers.Length;
            int summ = allNumbers.Sum();
            int targetSum = summ / 2;

            var can = new int[100*200];
            can[0] = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = summ; j + 1 > 0; j--)
                {
                    if (can[j] == 1)
                    {
                        can[j + allNumbers[i]] = 1;
                    }
                }
            }

            for (int i = targetSum; i > 1 ; i--)
            {
                if (can[i] == 1)
                {
                    Console.WriteLine("Difference: {0}", summ - 2 * i);
                    Console.WriteLine($"Alan:{i} Bob:{summ - i }");
                    //Console.WriteLine("Alan takes: {0}", string.Join(", ", targetSubset));
                    Console.WriteLine("Bob takes the rest.");
                    return;
                }
            }
        }
    }
}
