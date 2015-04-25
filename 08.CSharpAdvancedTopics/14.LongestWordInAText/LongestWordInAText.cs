using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestWordInAText
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();

        string longestWord = "";
        for (int i = 0; i < arr.Length; i++)
        {
            if (longestWord.Length < arr[i].Length)
            {
                longestWord = arr[i];
            }
        }
        Console.WriteLine(longestWord);
    }
}

