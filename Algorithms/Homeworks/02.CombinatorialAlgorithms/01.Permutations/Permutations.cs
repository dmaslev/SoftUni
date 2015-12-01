namespace _01.Permutations
{
    using System;
    using System.Linq;

    class Permutations
    {
        private static int countOfPermutations = 0;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = Enumerable.Range(1, n).ToArray();
            Permute(array);

            Console.WriteLine($"Total permutations: {countOfPermutations}");
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                Console.WriteLine(string.Join(", ", array));
                ++countOfPermutations;
            }
            else
            {
                for (int i = startIndex; i < array.Length; i++)
                {
                    Swap(ref array[startIndex], ref array[i]);
                    Permute(array, startIndex + 1);
                    Swap(ref array[startIndex], ref array[i]);
                }
            }
        }

        private static void Swap(ref int p1, ref int p2)
        {
            if (p1 == p2)
            {
                return;
            }

            p1 ^= p2;
            p2 ^= p1;
            p1 ^= p2;
        }
    }
}