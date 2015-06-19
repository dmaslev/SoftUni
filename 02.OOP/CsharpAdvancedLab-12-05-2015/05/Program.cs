using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


class Program
{
    private static string[] temp;
    private static int maxRec = 0;
    static void Main()
    {
        List<string> list = new List<string>();
        string input = Console.ReadLine();
        while (input != "END")
        {
            list.Add(input);
            input = Console.ReadLine();
        }
        temp = list[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[,] matrix = new string[list.Count, temp.Length];
        FillMatrix(list, matrix);
        AllRectangles(matrix);

    }

    private static void AllRectangles(string[,] matrix)
    {
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;

        for (int upRow = 0; upRow < matrix.GetLength(0)  ; upRow++)
        {
            for (int upCol = 0; upCol < matrix.GetLength(1); upCol++)
            {
                for (int downRow = upRow; downRow < matrix.GetLength(0); downRow++)
                {
                    for (int downCol = upCol; downCol < matrix.GetLength(1); downCol++)
                    {
                        if (ChechForRectangle(matrix, upRow, upCol, downRow, downCol))
                        {
                            int recArea = (1 + downRow - upRow) * (1 + downCol - upCol);
                            if (recArea > maxRec)
                            {
                                maxRec = recArea;
                                x1 = upRow;
                                y1 = upCol;
                                x2 = downRow;
                                y2 = downCol;
                            }
                        }
                    }
                }
            }
        }
        PrintResult(matrix, x1, y1, x2, y2);

    }

    private static void PrintResult(string[,] matrix, int x1, int y1, int x2, int y2)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == x1 && j >= y1 && j <= y2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,5}", "[" + SecurityElement.Escape(matrix[i, j]) + "]");
                }
                else if (i == x2 && j >= y1 && j <= y2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,5}", "[" + SecurityElement.Escape(matrix[i, j]) + "]");

                }
                else if ((j == y1 || j == y2) && i >= x1 && i <= x2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,5}", "[" + SecurityElement.Escape(matrix[i, j]) + "]");

                }
                else
                {
                    Console.Write("{0,5}", SecurityElement.Escape(matrix[i, j]));
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }

    }

    private static bool ChechForRectangle(string[,] matrix, int upRow, int upCol, int downRow, int downCol)
    {
        for (int i = upCol ; i <= downCol; i++)
        {
            if (matrix[upRow, upCol] != matrix[upRow, i])
            {
                return false;
            }
            if (matrix[upRow, upCol] != matrix[downRow, i])
            {
                return false;
            }
        }
        for (int i = upRow; i <= downRow ; i++)
        {
            if (matrix[upRow, upCol] != matrix[i, upCol])
            {
                return false;
            }
            if (matrix[upRow, upCol] != matrix[i, downCol])
            {
                return false;
            }
        }
        return true;
    }

    private static void FillMatrix(List<string> list, string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = list[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = temp[j];
            }
        }
    }
}

