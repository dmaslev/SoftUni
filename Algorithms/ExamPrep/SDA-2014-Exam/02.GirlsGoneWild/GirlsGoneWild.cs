namespace _02.GirlsGoneWild
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GirlsGoneWild
    {
        private static SortedSet<string> result;
        private static int girlsCount;
        private static int[] nums;
        private static int k;
        private static string skirts;

        static void Main()
        {
            result = new SortedSet<string>();
            k = int.Parse(Console.ReadLine());
             skirts = Console.ReadLine();
            girlsCount = int.Parse(Console.ReadLine());
            nums = new int[girlsCount];
            NestedLoops(0, 0);

            Console.WriteLine(result.Count);
            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }


        private static void NestedLoops(int currentLoop, int index)
        {
            if (currentLoop == girlsCount)
            {
                int[] array = new int[girlsCount];
                bool[] used = new bool[skirts.Length + 1];
                GenerateVariations(array, skirts.Length, used);
                return;
            }

            for (int i = index; i < k; i++)
            {
                nums[currentLoop] = i;
                NestedLoops(currentLoop + 1, i + 1);
            }
        }

        private static void GenerateVariations(int[] array, int sizeOfset, bool[] used, int index = 0)
        {
            if (index >= array.Length)
            {
                var temp = new StringBuilder();
                temp.Append(nums[0].ToString() + skirts[array[0]]);
                for (int i = 1; i < girlsCount; i++)
                {
                    temp.Append(string.Format("-{0}{1}", nums[i], skirts[array[i]]));
                }

                result.Add(temp.ToString());
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
    }
}
