using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class WordCount
{
    static void Main()
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        List<string> words = new List<string>();
        string[] temp;

        using (StreamReader readerWords = new StreamReader("words.txt"))
        {
            while (!readerWords.EndOfStream)
            {
                temp = readerWords.ReadLine().ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in temp)
                {
                    words.Add(s);
                    result.Add(s, 0);
                }
            }
        }
        using (StreamReader readerText = new StreamReader("text.txt"))
        {
            string currentLine = readerText.ReadLine();
            while (currentLine != null)
            {
                currentLine = currentLine.ToLower();
                foreach (var word in words)
                {
                    string currentWord = word;
                    string pattern = @"\b" + currentWord + @"\b";
                    Regex regex = new Regex(pattern);
                    MatchCollection matches = regex.Matches(currentLine);
                    result[word] += matches.Count;
                }
                currentLine = readerText.ReadLine();
            }
        }
        using (StreamWriter writer = new StreamWriter("result.txt"))
        {
            foreach (var item in result.OrderByDescending(key => key.Value))
            {
                writer.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }

    }
}

