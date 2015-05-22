using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PaintBall
{
    static void Main()
    {
        char[,] matrix = new char [10,10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = '1';
            }
        }
        string line = Console.ReadLine();
        bool isWhite = false;
        char currentChar = '0';

        while (line != "End")
        {
            if (isWhite)
            {
                currentChar = '1';
            }
            else
            {
                currentChar = '0';
            }
            int[] number = line.Split().Select(int.Parse).ToArray();
            int currentRow = number[0];
            int currentCol = number[1];
            int r = number[2];
            for (int row = Math.Max(0, currentRow - r); row <= Math.Min(9, currentRow + r); row++)
            {
                for (int col = Math.Max(0, currentCol - r); col <= Math.Min(9, currentCol + r); col++)
                {
                    
                    matrix[row, col] = currentChar;
                }
            }
            line = Console.ReadLine();
            isWhite = !isWhite;
        }
        int sum = 0;
        string currentLine= "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 9; j >= 0; j--)
			{
                currentLine += "" + matrix[i, j];
			}
            sum += Convert.ToInt32(currentLine, 2);
            currentLine = string.Empty;
        }
        Console.WriteLine(sum);
    }
}

