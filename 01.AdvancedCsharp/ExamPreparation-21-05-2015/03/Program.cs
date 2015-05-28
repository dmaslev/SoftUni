using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<char[]> matrix = new List<char[]>();

        const string symbols = "<>^v";
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "END")
            {
                break;
            }
            matrix.Add(line.ToCharArray());
        }
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                int currentRow;
                int currentCol;

                switch (matrix[row][col])
                {
                    case '<':
                        currentRow = row;
                        currentCol = col - 1;
                        while (currentCol >= 0 && !symbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentCol--;
                        }
                        break;
                    case '>':
                        currentRow = row;
                        currentCol = col + 1;
                        while (currentCol < matrix[currentRow].Length && !symbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentCol++;
                        }
                        break;
                    case '^':
                        currentRow = row - 1;
                        currentCol = col;
                        while (currentRow >= 0 && !symbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentRow--;
                        }
                        break;
                    case 'v':
                        currentRow = row + 1;
                        currentCol = col;
                        while (currentRow < matrix.Count && !symbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentRow++;
                        }
                        break;
                    default:
                        break;
                }

            }
        }
        PrintMatrix(matrix);

    }
    private static void PrintMatrix(List<char[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            Console.WriteLine("<p>{0}</p>", SecurityElement.Escape( new string(matrix[row])));
        }
    }
}

