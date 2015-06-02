using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string dimension = Console.ReadLine();
        string[] dimensions = dimension.Split();
        int row = int.Parse(dimensions[0]);
        int col = int.Parse(dimensions[1]);

        string word = Console.ReadLine();
        string shot = Console.ReadLine();
        char[,] matrix = new char[row, col];

        FillTheMatrix(matrix, word);
        MakeAShot(matrix, shot);
        for (int c = 0; c < matrix.GetLength(1); c++)
        {
            TurnOnTheGravity(matrix, c);
        }
        PrintMatrix(matrix);
    }

    private static void TurnOnTheGravity(char[,] matrix, int col)
    {
        while (true)
        {
            bool hasFallen = false;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                char topChar = matrix[row - 1, col];
                char currentChar = matrix[row, col];
                if (currentChar == ' ' && topChar != ' ')
                {
                    matrix[row, col] = topChar;
                    matrix[row - 1, col] = ' ';
                    hasFallen = true;
                }
            }

            if (!hasFallen)
            {
                break;
            }
        }
    }

    private static void MakeAShot(char[,] matrix, string shot)
    {
        int[] boom = shot.Split().Select(int.Parse).ToArray();
        int centerRow = boom[0];
        int centerCol = boom[1];
        int radius = boom[2];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                double distance = Math.Sqrt((row - centerRow) * (row - centerRow) + (col - centerCol) * (col - centerCol));
                if (distance <= radius)
                {
                    matrix[row, col] = ' ';
                }
            }
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void FillTheMatrix(char[,] matrix, string word)
    {
        bool isEvenRow = true;
        int counter = 0;
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            if (isEvenRow)
            {
                for (int j = matrix.GetLength(1)- 1; j >=0 ; j--)
                {
                    matrix[i, j] = word[counter % word.Length];
                    counter++;
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = word[counter % word.Length];
                    counter++;
                }
            }
            isEvenRow = !isEvenRow;
        }
    }
}

