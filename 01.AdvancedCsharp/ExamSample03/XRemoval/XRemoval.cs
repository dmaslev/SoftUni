using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class XRemoval
{
    static void Main()
    {
        List<char[]> matrix = new List<char[]>();
        string input = Console.ReadLine();
        List<char[]> result = new List<char[]>();
        while (input != "END")
        {
            matrix.Add(input.PadRight(100).ToLower().ToCharArray());
            result.Add(input.PadRight(100).ToCharArray());
            input = Console.ReadLine();
        }

        for (int row = 0; row < matrix.Count - 2; row++)
        {
            for (int col = 0; col < matrix[row].Length-2; col++)
            {
                if (matrix[row][col] == matrix[row][col+2] &&
                    matrix[row][col] == matrix[row+1][col+1] &&
                    matrix[row][col] == matrix[row+2][col] &&
                    matrix[row][col] == matrix[row+2][col+2])
                {
                    result[row][col] = ' ';
                    result[row][col+2] = ' ';
                    result[row+1][col+1] = ' ';
                    result[row+2][col] = ' ';
                    result[row+2][col+2] = ' ';
                }
            }
        }
        foreach (var row in result)
        {
            foreach (var symbol in row)
            {
                if (symbol != ' ')
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }
    }
}

