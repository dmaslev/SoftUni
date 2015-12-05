namespace _08.Needles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Needles
    {

        static void Main()
        {
            string bullshit = Console.ReadLine();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = FindIndex(array, numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static int FindIndex(int[] array, int v)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (v > array[i] && array[i] != 0)
                {
                    return i+ 1;
                }
            }

            return 0;
        }
    }
}
