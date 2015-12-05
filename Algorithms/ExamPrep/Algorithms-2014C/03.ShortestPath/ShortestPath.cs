using System;
using System.Collections.Generic;

class ShortestPath
{
    private static SortedSet<string> allPaths;
    private static char[] directions = new char[] { 'L', 'R', 'S' };

    static void Main()
    {
        allPaths = new SortedSet<string>();
        char[] input = Console.ReadLine().ToCharArray();

        FillEmptySpaces(input, 0);
        PrintResult();
    }

    private static void PrintResult()
    {
        Console.WriteLine(allPaths.Count);
        foreach (var path in allPaths)
        {
            Console.WriteLine(path);
        }
    }

    private static void FillEmptySpaces(char[] input, int index)
    {
        if (index == input.Length)
        {
            allPaths.Add(new string(input));
            return;
        }

        if (input[index] != '*')
        {
            FillEmptySpaces(input, index + 1);
            return;
        }

        for (int i = 0; i < 3; i++)
        {
            input[index] = directions[i];
            FillEmptySpaces(input, index + 1);
            input[index] = '*';
        }
    }
}

