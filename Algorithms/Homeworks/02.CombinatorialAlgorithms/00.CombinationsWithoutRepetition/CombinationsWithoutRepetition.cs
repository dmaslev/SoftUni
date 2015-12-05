namespace _00.CombinationsWithRepetition
{
    using System;

    class CombinationsWithoutRepetition
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            GenerateCombinations(array, n, 0);
        }

        private static void GenerateCombinations(int[] array, int sizeOfSet, int index, int start = 1)
        {
            if (index >= array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = start; i <= sizeOfSet; i++)
                {
                    array[index] = i;
                    GenerateCombinations(array, sizeOfSet, index + 1, i + 1);
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine($"{string.Join(", ", array)}");
        }
    }
}
