namespace _01.GoupPermutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GoupPermutations
    {
        private static StringBuilder result;
        private static Dictionary<char, byte> counter;

        static void Main()
        {
            string inputLine = Console.ReadLine();
            result = new StringBuilder();
            counter = new Dictionary<char, byte>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (!counter.ContainsKey(inputLine[i]))
                {
                    counter.Add(inputLine[i], 1);
                }
                else
                {
                    counter[inputLine[i]]++;
                }
            }

            var allChars = inputLine.ToCharArray().Distinct();
            char[] noDuplicates = allChars.Cast<char>().ToArray();

            GeneratePermutations(noDuplicates, 0);
        }

        static void GeneratePermutations(char[] arr, int k)
        {
            if (k >= arr.Length)
            {
                Print(arr);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void Print(char[] arr)
        {
            result.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(new string(arr[i], counter[arr[i]]));
            }
            Console.WriteLine(result.ToString().Trim());
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
