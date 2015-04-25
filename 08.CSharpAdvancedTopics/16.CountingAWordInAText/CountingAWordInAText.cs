using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountingAWordInAText
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        string line = Console.ReadLine().ToLower();
        string[] arr = line.Split(' ', '.', '?', '!', ':', ';', '-', '(', ')', '[', ']', '\'', '\"', '/', ',', '“');
        int counter = 0;
        foreach (var str in arr)
        {
            if (str == word)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

