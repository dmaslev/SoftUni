using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractURLsFromText
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > 6)
            {
                if (arr[i].Substring(0, 7) == "http://" || arr[i].Substring(0, 4) == "www.")
                {
                    Console.WriteLine(arr[i]);
                }
            }
            
        }
    }
}

