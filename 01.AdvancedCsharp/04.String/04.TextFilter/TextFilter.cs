using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextFilter
{
    static void Main()
    {
        string[] bannedWord = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        for (int i = 0; i < bannedWord.Length; i++)
        {
            int startIndex = text.IndexOf(bannedWord[i]);

            while (startIndex != - 1)
            {
                text = text.Replace(text.Substring(startIndex, bannedWord[i].Length), new string('*', bannedWord[i].Length));
                startIndex = text.IndexOf(bannedWord[i], startIndex + 1);
            }            
        }
        Console.WriteLine(text);
    }
}

