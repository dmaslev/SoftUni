namespace _01.Portals
{
    using System;
    using System.Linq;

    class Portals
    {
        private static int[,] matrix;
        private static int maxSum = 0;

        static void Main()
        {
            var first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var second = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startRow = first[0];
            int startCol = first[1];
            int rows = second[0];
            int cols = second[1];
            matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    if (input[j] != "#")
                    {
                        matrix[i, j] = int.Parse(input[j]);
                    }
                    else
                    {
                        matrix[i, j] = -1;
                    }
                }
            }

            BFS(new Position { Row = startRow, Col = startCol, Value = 0 });
            Console.WriteLine(maxSum);
        }

        private static void BFS(Position position)
        {
            if (position.Value > maxSum)
            {
                maxSum = position.Value;
            }

            var currentValue = matrix[position.Row, position.Col];
            if (currentValue > 0)
            {
                int nextValue = position.Value + currentValue;
                if (isInRange(position.Row - currentValue, position.Col))
                {
                    matrix[position.Row, position.Col] = 0;
                    BFS(new Position { Row = position.Row - currentValue, Col = position.Col, Value = nextValue, });
                    matrix[position.Row, position.Col] = currentValue;
                }

                if (isInRange(position.Row + currentValue, position.Col))
                {
                    matrix[position.Row, position.Col] = 0;
                    BFS(new Position { Row = position.Row + currentValue, Col = position.Col, Value = nextValue, });
                    matrix[position.Row, position.Col] = currentValue;
                }

                if (isInRange(position.Row, position.Col - currentValue))
                {
                    matrix[position.Row, position.Col] = 0;
                    BFS(new Position { Row = position.Row, Col = position.Col - currentValue, Value = nextValue, });
                    matrix[position.Row, position.Col] = currentValue;
                }

                if (isInRange(position.Row, position.Col + currentValue))
                {
                    matrix[position.Row, position.Col] = 0;
                    BFS(new Position { Row = position.Row, Col = position.Col + currentValue, Value = nextValue, });
                    matrix[position.Row, position.Col] = currentValue;
                }
            }
        }

        private static bool isInRange(int row, int col)
        {
            if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1) && matrix[row, col] != -1)
            {
                return true;
            }

            return false;
        }
    }

    public class Position
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Value { get; set; }
    }
}
