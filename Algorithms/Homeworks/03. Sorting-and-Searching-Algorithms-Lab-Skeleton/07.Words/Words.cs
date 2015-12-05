namespace _07.Words
{
    using System;

    class Words
    {
        private static int counter = 0;

        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Sort(input);
            PermuteRep(input, 0, input.Length-1);
            Console.WriteLine(counter);
        }

        private static void PermuteRep(char[] numbers, int start, int end)
        {
            if (IsValidSolution(numbers))
            {
                counter++;
            }

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

        private static bool IsValidSolution(char[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    return false;
                }
            }

            return true;
        }

        private static void Swap(ref char p1, ref char p2)
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
