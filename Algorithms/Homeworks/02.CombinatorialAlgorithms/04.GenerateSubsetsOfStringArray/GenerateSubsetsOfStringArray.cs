namespace _04.GenerateSubsetsOfStringArray
{
    using System;

    class GenerateSubsetsOfStringArray
    {
        private static string[] result;
        private static int k;


        static void Main()
        {
            string[] words = new string[] { "test", "rock", "fun" };
            k = 2;
            result = new string[k];
            Permute(words, 0, 0);
        }

        private static void Permute(string[] words, int v1, int v2)
        {
            if (v1 == k)
            {
                Print();
            }
            else
            {
                for (int i = v2; i < words.Length; i++)
                {
                    result[v1] = words[i];
                    Permute(words, v1 + 1, i + 1);
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
