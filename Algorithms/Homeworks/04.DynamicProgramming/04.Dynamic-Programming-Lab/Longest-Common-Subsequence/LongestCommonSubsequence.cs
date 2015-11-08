namespace Longest_Common_Subsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestCommonSubsequence
    {
        public static void Main()
        {
            var firstStr = "tree";
            var secondStr = "team";

            var lcs = FindLongestCommonSubsequence(firstStr, secondStr);

            Console.WriteLine("Longest common subsequence:");
            Console.WriteLine("  first  = {0}", firstStr);
            Console.WriteLine("  second = {0}", secondStr);
            Console.WriteLine("  lcs    = {0}", lcs);
        }

        public static string FindLongestCommonSubsequence(string firstStr, string secondStr)
        {
            int firstLength = firstStr.Length + 1;
            int secondLength = secondStr.Length + 1;
            var lcs = new int[firstLength, secondLength];

            for (int i = 1; i < firstLength; i++)
            {
                for (int j = 1; j < secondLength; j++)
                {
                    if (firstStr[i - 1] == secondStr[j - 1])
                    {
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }
            }

            List<char> sequence = RetrieveLCS(firstStr, secondStr, lcs);
            sequence.Reverse();
            return new string(sequence.ToArray());
        }

        private static List<char> RetrieveLCS(string firstStr, string secondStr, int[,] lcs)
        {
            List<char> lcsWord = new List<char>();

            for (int i = lcs.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = lcs.GetLength(1) - 1; j >= 0; j--)
                {
                    while (i > 0 && j > 0)
                    {
                        if (firstStr[i - 1] == secondStr[j - 1])
                        {
                            lcsWord.Add(firstStr[i - 1]);
                            j--;
                            i--;
                        }
                        else if (lcs[i, j] == lcs[i - 1, j])
                        {
                            i--;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
            }

            return lcsWord;
        }
    }
}
