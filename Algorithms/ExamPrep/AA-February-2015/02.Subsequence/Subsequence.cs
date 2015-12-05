using System;

public class Subsequence
{
    public static void Main()
    {
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        var firstLine = Console.ReadLine().Split();
        var secondLine = Console.ReadLine().Split();
        int[,] matrix = new int[firstLine.Length + 1, secondLine.Length + 1];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[0, i] = 0;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[0, i] = 0;
        }

        for (int r = 1; r < matrix.GetLength(0); r++)
        {
            for (int c = 1; c < matrix.GetLength(1); c++)
            {
                if (firstLine[r - 1] == secondLine[c - 1])
                {
                    matrix[r, c] = matrix[r - 1, c - 1] + 1;
                }
                else
                {
                    matrix[r, c] = Math.Max(matrix[r, c - 1], matrix[r - 1, c]);
                }
            }
        }

        Console.WriteLine(matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]);
    }
}