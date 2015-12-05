namespace _00.GenerateVariationsWithRepetition
{
    using System;

    class VariationsWithRepetition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];

            GenerateVariations(array, n);
        }

        private static void GenerateVariations(int[] array, int sizeOfset, int index = 0)
        {
            if (index >= array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 1; i <= sizeOfset; i++)
                {
                    array[index] = i;
                    GenerateVariations(array, sizeOfset, index + 1);
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine($"{string.Join(", ", array)}");
        }
    }
}
