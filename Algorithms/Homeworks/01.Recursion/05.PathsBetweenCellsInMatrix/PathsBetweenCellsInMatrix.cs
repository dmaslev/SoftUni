using System;
using System.Collections.Generic;

class PathsBetweenCellsInMatrix
{
    static char[,] lab = 
    {
        {' ', ' ', ' ', ' '},
        {' ', '*', '*', ' '},
        {' ', '*', '*', ' '},
        {' ', '*', 'e', ' '},
        {' ', ' ', ' ', ' '},
    };

    //static char[,] lab = 
    //{
    //    {' ', ' ', ' ', ' ', ' ', ' '},
    //    {' ', '*', '*', ' ', '*', ' '},
    //    {' ', '*', '*', ' ', '*', ' '},
    //    {' ', '*', 'e', ' ', ' ', ' '},
    //    {' ', ' ', ' ', '*', ' ', ' '},
    //};

    static List<char> path = new List<char>();

    static void Main()
    {
        FindExit(0, 0, 'R');
    }

    private static void FindExit(int row, int col, char direction)
    {
        if (row < 0 || col < 0 || row >= lab.GetLength(0) || col >= lab.GetLength(1))
        {
            return;
        }

        if (lab[row, col] == 'e')
        {
            Console.WriteLine(string.Join("", path) + direction);
            return;
        }

        if (lab[row, col] != ' ')
        {
            return;
        }

        lab[row, col] = 'x';
        path.Add(direction);

        FindExit(row, col + 1, 'R');
        FindExit(row + 1, col, 'D');
        FindExit(row, col - 1, 'L');
        FindExit(row - 1, col, 'U');

        lab[row, col] = ' ';
        path.RemoveAt(path.Count - 1);

    }
}