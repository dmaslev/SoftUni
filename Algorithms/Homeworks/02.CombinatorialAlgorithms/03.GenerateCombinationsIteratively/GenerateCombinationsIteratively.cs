
namespace _03.GenerateCombinationsIteratively
{
    using System;
    using System.Linq;

    class GenerateCombinationsIteratively
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = Enumerable.Range(1, k).ToArray();

            while (true)
            {
                Print(arr);
                if (arr[0] + k > n)
                {
                    break;
                }

                int digitIndex = k - 1;
                while (arr[digitIndex] + k - digitIndex > n)
                {
                    --digitIndex;
                }

                arr[digitIndex]++;
                for (int i = digitIndex + 1; i < k; i++)
                {
                    arr[i] = arr[i-1] + 1;
                }
            }
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine("(" + string.Join(", ", arr) + ")");
        }
    }
}
