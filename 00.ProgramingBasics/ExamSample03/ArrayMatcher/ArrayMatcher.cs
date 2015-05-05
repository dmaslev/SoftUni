using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayMatcher
{
    static void Main()
    {
        string inp = Console.ReadLine();
        string[] input = inp.Split('\\');
        string first = input[0];
        string second = input[1];
        string result = string.Empty;
        if (input[2] == "join")
        {
            for (int i = 0; i < first.Length; i++)
            {
                for (int s = 0; s < second.Length; s++)
                {
                    if (first[i] == second [s])
                    {
                        result = result + "" + first[i];
                    }
                }
            }
        }
        else if (input[2] == "right exclude")
        {
            for (int i = 0; i < first.Length; i++)
            {                
                if (!second.Contains(first[i]))
                {
                    result = result + first[i];
                }                
            }
        }
        else if (input[2] == "left exclude")
        {            
            for (int s = 0; s < second.Length; s++)
            {
                if (!first.Contains(second[s]))
                {
                    result = result + second[s];
                }
            }            
        }
        string[] output = new string[result.Length];
        for (int i = 0; i < result.Length; i++)
        {
            output[i] = result[i].ToString();
        }
        Array.Sort(output, StringComparer.Ordinal);
        foreach(string i in output)
        {
            Console.Write(i);
        }
    }
}

