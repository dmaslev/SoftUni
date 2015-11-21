namespace _04.LineInverter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LineInverter
    {
        private static int n;
        private static bool[,] matrix;
        private static int invertions = -1;


        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            matrix = new bool[n, n];
            string inputLine;

            for (int i = 0; i < n; i++)
            {
                inputLine = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = inputLine[j] == 'B';
                }
            }
            bool[] usedRows = new bool[n];
            bool[] usedCols = new bool[n];

            for (int i = 0; i < 2 * n; i++)
            {
                List<int> whiteCellsInRow = (new int[n]).ToList();
                List<int> whiteCellsInColumn = (new int[n]).ToList();
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (!matrix[row, col])
                        {
                            whiteCellsInColumn[col]++;
                            whiteCellsInRow[row]++;
                        }
                    }
                }

                int maxWhiteRow = whiteCellsInRow.Max();
                int maxWhiteCol = whiteCellsInColumn.Max();
                if (maxWhiteCol == 0 && maxWhiteRow == 0)
                {
                    // No white cells -> solution found
                    Console.WriteLine(++invertions);
                    return;
                }

                if (maxWhiteRow >= maxWhiteCol)
                {
                    InvertRow(whiteCellsInRow.IndexOf(maxWhiteRow));
                    invertions++;
                }
                else if (maxWhiteCol > maxWhiteRow)
                {
                    InvertCol(whiteCellsInColumn.IndexOf(maxWhiteCol));
                    invertions++;
                }
            }

            Console.WriteLine(-1);
        }

        private static void InvertCol(int maxWhiteCol)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i, maxWhiteCol] = !matrix[i, maxWhiteCol];
            }
        }

        private static void InvertRow(int maxWhiteRow)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[maxWhiteRow, i] = !matrix[maxWhiteRow, i];
            }
        }
    }
}
