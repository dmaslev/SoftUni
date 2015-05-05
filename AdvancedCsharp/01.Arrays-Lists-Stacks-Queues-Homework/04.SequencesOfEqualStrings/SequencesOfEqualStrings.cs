using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequencesOfEqualStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] word = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> result = new List<string>();
        result.Add(word[0]);
        for (int i = 0; i < word.Length - 1; i++)
        {

            if (word[i] == word [i+1])
            {
                result.Add(word[i]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
                result.Clear();
                result.Add(word[i+1]);
            }            
        }
        Console.WriteLine(string.Join(" ", result));


    }
}

