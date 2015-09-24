using System;
using System.Collections.Generic;

class ConnectedAreasInMatrix
{
    static SortedSet<Area> areas = new SortedSet<Area>();
    private static char[,] matrix = 
    {
        {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
        {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
        {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' '},
    };

    //private static char[,] matrix = 
    //{
    //    {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
    //    {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
    //    {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
    //    {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
    //    {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
    //};

    static void Main()
    {
        FindFirstTraversableCell();
        PrintAllConnectedAreas(areas);
    }

    private static void PrintAllConnectedAreas(SortedSet<Area> areas)
    {
        Console.WriteLine("Total areas found: {0}", areas.Count);
        foreach (Area area in areas)
        {
            Console.WriteLine(area);
        }
    }

    private static void FindFirstTraversableCell()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row,col] == ' ')
                {
                    Area area = new Area(row, col);
                    FindConnectedArea(row, col, area);
                    areas.Add(area);                    
                }
            }
        }

        return;
    }

    private static void FindConnectedArea(int row, int col, Area area)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return;
        }

        if (matrix[row, col] != ' ')
        {
            return;
        }

        matrix[row, col] = '.';
        area.Size++;

        FindConnectedArea(row, col + 1, area);
        FindConnectedArea(row + 1, col, area);
        FindConnectedArea(row, col - 1, area);
        FindConnectedArea(row - 1, col, area);
    }
}