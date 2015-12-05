namespace _01.Frames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Frames
    {
        private static SortedSet<string> allFrames;

        static void Main()
        {
            allFrames = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            var arr = new Tuple<int, int>[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arr[i] = new Tuple<int, int>(input[0], input[1]);
            }

            Permute(arr);
            Console.WriteLine(allFrames.Count);
            var result = new StringBuilder();
            foreach (var item in allFrames)
            {
                result.AppendLine(item);
            }

            Console.WriteLine(result.ToString().Trim());
        }

        private static void Permute(Tuple<int, int>[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length)
            {
                string permutation = String.Join(" | ", (object[])array);
                allFrames.Add(permutation);
            }
            else
            {
                for (int i = startIndex; i < array.Length; i++)
                {
                    Swap(ref array[startIndex], ref array[i]);
                    Permute(array, startIndex + 1);
                    SwapCurrentTuple(ref array[startIndex]);
                    Permute(array, startIndex + 1);
                    SwapCurrentTuple(ref array[startIndex]);
                    Swap(ref array[i], ref array[startIndex]);
                }
            }
        }

        private static void SwapCurrentTuple(ref Tuple<int, int> tuple)
        {
            var first = tuple.Item1;
            var second = tuple.Item2;

            tuple = new Tuple<int, int>(second, first);
        }

        private static void Swap(ref Tuple<int, int> i, ref Tuple<int, int> j)
        {
            if (i == j)
            {
                return;
            }

            var temp = i;
            i = j;
            j = temp;
        }
    }
}
