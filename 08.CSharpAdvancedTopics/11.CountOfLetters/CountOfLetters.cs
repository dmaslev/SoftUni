using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] names = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(names);
        string currentName = names[0];
        int counter = 1;
        for (int i = 1; i < names.Length; i++)
        {
            if (currentName == names[i])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", currentName, counter);
                currentName = names[i];
                counter = 1;
            }
        }
        Console.WriteLine("{0} -> {1}", currentName, counter);



    }
}

