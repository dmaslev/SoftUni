namespace _00.GenerateVariationsWithRepetition
{
    using System;

    class VariationsWithoutRepetition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            bool[] used = new bool[n + 1];

            GenerateVariations(array, n, used);
        }

        private static void GenerateVariations(int[] array, int sizeOfset, bool[] used, int index = 0)
        {
            if (index >= array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 0; i < sizeOfset; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        array[index] = i;
                        GenerateVariations(array, sizeOfset, used, index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine($"{string.Join(", ", array)}");
        }
    }
}
