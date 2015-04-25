using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class JoinLists
{
    static void Main()
    {
        string first = Console.ReadLine();
        List<string> firstNumbers = new List<string>(first.Split());
        string second = Console.ReadLine();
        List<string> secondNumbers = new List<string>(second.Split());

        foreach (var number in secondNumbers)
        {
            if (!firstNumbers.Contains(number))
            {
                firstNumbers.Add(number);
            }
        }
        List<string> result = new List<string>();
        foreach (var number in firstNumbers)
        {
            if (!(result.Contains(number)))
	        {
                result.Add(number);
	        }
        }
        result.Sort();

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");   
        }
        Console.WriteLine();
    }
}

