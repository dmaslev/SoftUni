using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] result = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] command = input.Split();
            if (command[0] == "reverse")
            {
                Reverse(command, result);
            }
            else if (command[0] == "sort")
            {
                Sort(command, result);
            }
            else if (command[0] == "rollLeft")
            {
                RollLeft(command, result);
            }
            else if (command[0] == "rollRight")
            {
                RollRight(command, result);
            }
            input = Console.ReadLine();
        }
        Console.WriteLine("[{0}]", string.Join(", ", result));
    }

    private static void RollLeft(string[] command, string[] result)
    {
        long count = long.Parse(command[1]);
        if (count < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        count = count % result.Length;
        for (int a = 0; a < count; a++)
        {
            string temp = result[0];

            for (int i = 0; i < result.Length - 1; i++)
            {
                result[i] = result[i + 1];
            }
            result[result.Length - 1] = temp;
        }
    }

    private static void RollRight(string[] command, string[] result)
    {
        long count = long.Parse(command[1]);
        if (count < 0)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        count = count % result.Length;
        for (int a = 0; a < count; a++)
        {
            string temp = result[result.Length - 1];

            for (int i = result.Length - 1; i >= 1; i--)
            {
                result[i] = result[i - 1];
            }
            result[0] = temp;
        }
    }

    private static void Sort(string[] command, string[] result)
    {
        long startIndex = long.Parse(command[2]);
        long count = long.Parse(command[4]);
        if (startIndex < 0 || startIndex >= result.Length ||
            count < 0 || startIndex + count > result.Length)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        List<string> sortedPartition = new List<string>();
        for (long i = startIndex; i < startIndex + count; i++)
        {
            sortedPartition.Add(result[i]);
        }
        var sort = from s in sortedPartition
                   orderby s
                   select s;
        var aaaaa = sort.ToArray();

        for (long i = startIndex; i < startIndex + count; i++)
        {
            result[i] = aaaaa[(int)i - startIndex];
        }
    }

    private static void Reverse(string[] command, string[] result)
    {
        long startIndex = long.Parse(command[2]);
        long count = long.Parse(command[4]);
        if (startIndex < 0 || startIndex >= result.Length ||
            count < 0 || startIndex + count > result.Length)
        {
            Console.WriteLine("Invalid input parameters.");
            return;
        }
        List<string> reversed = new List<string>();
        for (long i = startIndex; i < startIndex + count; i++)
        {
            reversed.Add(result[i]);
        }
        string[] reeev = reversed.ToArray();
        Array.Reverse(reeev);

        for (long i = startIndex; i < startIndex + count; i++)
        {
            result[i] = reeev[(int)i - startIndex];
        }
    }
}

