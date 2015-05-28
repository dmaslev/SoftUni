using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        const string OblascleChar = "*#@";
        int n = int.Parse(Console.ReadLine());
        int movesMade = 0;
        char[][] matrix = new char[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine().ToCharArray();
        }
        string commands = Console.ReadLine();
        int livesLeft = 3;
        int row = 0;
        int col = 0;

        foreach (var direction in commands)
        {
            int previousRow = row;
            int previousCow = col;
            switch (direction)
            {
                case  '<':
                    col--;
                    break;
                case'>':
                    col++;
                    break;
                case '^':
                    row--;
                    break;
                case 'v':
                    row++;
                    break;
                default:
                    break;
            }
            if (!IsCellOutsideMatrix(row, col, matrix) || matrix[row][col] == ' ')
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                movesMade++;
                break;
            }
            else if (matrix[row][col] == '_' || matrix[row][col] == '|')
            {
                Console.WriteLine("Bumped a wall.");
                row = previousRow;
                col = previousCow;
            }
            else if (OblascleChar.Contains(matrix[row][col].ToString()))
            {
                livesLeft--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", livesLeft);
                if (livesLeft <= 0)
                {
                    Console.WriteLine("No lives left! Game Over!");
                    break;
                }
            }
            else if (matrix[row][col] == '$')
            {
                livesLeft++;
                movesMade++;
                matrix[row][col] = '.';
                Console.WriteLine("Awesome! Lives left: {0}", livesLeft);
            }
            else
            {
                Console.WriteLine("Made a move!");
                movesMade++;
            }
        }
        Console.WriteLine("Total moves made: {0}", movesMade);
    }
    private static bool IsCellOutsideMatrix(int row, int col, char[][] matrix)
    {
        bool isRowInsideMatrix = 0 <= row && row < matrix.Length;


        if (!isRowInsideMatrix)
        {
            return false;
        }
        bool isCOlInRange = 0 <= col && col < matrix[row].Length;
        return isCOlInRange;
    }
}

