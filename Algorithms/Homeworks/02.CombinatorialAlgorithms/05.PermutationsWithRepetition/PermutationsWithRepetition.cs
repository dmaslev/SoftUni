namespace _05.PermutationsWithRepetition
{
    using System;

    class PermutationsWithRepetition
    {
        static void Main()
        {
            int[] numbers = new[] { 1, 3, 5, 5 };
            Array.Sort(numbers);
            PermuteRep(numbers, 0, numbers.Length - 1);
        }

        private static void PermuteRep(int[] numbers, int start, int end)
        {
            Print(numbers);

            for (int left = end - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                {
                    if (numbers[left] != numbers[right])
                    {
                        Swap(ref numbers[left], ref numbers[right]);
                        PermuteRep(numbers, left + 1, end);
                    }
                }

                var firstElement = numbers[left];
                for (int i = left; i <= end - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }

                numbers[end] = firstElement;
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            v1 ^= v2;
            v2 ^= v1;
            v1 ^= v2;
        }

        private static void Print(int[] numbers)
        {
            Console.WriteLine($"{string.Join(", ", numbers)}");
        }
    }
}
