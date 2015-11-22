namespace _01.ShortestPathInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShortestPathInMatrix
    {
        private static int[,] matrix;
        private static int[,] graph;

        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            matrix = new int[row, col];
            graph = new int[row * col, row * col];

            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int s = 0; s < col; s++)
                {
                    matrix[i, s] = input[s];
                }
            }
            InitializeGraph();
            FindAndPrintShortestPath(graph, 0, row * col - 1);
        }

        static List<int> Dijkstra(int[,] graph, int sourceNode, int destinationNode)
        {
            int n = graph.GetLength(0);

            int[] distance = new int[n];
            for (int i = 0; i < n; i++)
            {
                distance[i] = int.MaxValue;
            }
            distance[sourceNode] = 0;

            var used = new bool[n];
            int?[] previous = new int?[n];
            while (true)
            {
                int minDistance = int.MaxValue;
                int minNode = 0;
                for (int node = 0; node < n; node++)
                {
                    if (!used[node] && distance[node] < minDistance)
                    {
                        minDistance = distance[node];
                        minNode = node;
                    }
                }
                if (minDistance == int.MaxValue)
                {
                    break;
                }

                used[minNode] = true;

                for (int i = 0; i < n; i++)
                {
                    if (graph[minNode, i] > 0)
                    {
                        int newDistance = distance[minNode] + graph[minNode, i];
                        if (newDistance < distance[i])
                        {
                            distance[i] = newDistance;
                            previous[i] = minNode;
                        }
                    }
                }
            }

            if (distance[destinationNode] == int.MaxValue)
            {
                return null;
            }

            var path = new List<int>();
            int? currentNode = destinationNode;
            while (currentNode != null)
            {
                path.Add(currentNode.Value);
                currentNode = previous[currentNode.Value];
            }
            path.Reverse();
            return path;
        }

        static void FindAndPrintShortestPath(int[,] graph, int sourceNode, int destinationNode)
        {
            var path = Dijkstra(graph, sourceNode, destinationNode);

            int pathLength = matrix[0, 0];
            for (int i = 0; i < path.Count - 1; i++)
            {
                pathLength += graph[path[i], path[i + 1]];
            }
            var result = new List<int>();
            for (int i = 0; i < path.Count; i++)
            {
                int currentRow = path[i] / matrix.GetLength(1);
                int currentCol = path[i] % matrix.GetLength(1);

                result.Add(matrix[currentRow, currentCol]);
            }
            var formattedPath = string.Join(" ", result);

            Console.WriteLine($"Length: {pathLength}");
            Console.WriteLine($"Path: {formattedPath}");
        }

        private static void InitializeGraph()
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (c > 0)
                    {
                        graph[r * matrix.GetLength(1) + c, r * matrix.GetLength(1) + c - 1] = matrix[r, c - 1];
                    }
                    if (c < matrix.GetLength(1) - 1)
                    {
                        graph[r * matrix.GetLength(1) + c, r * matrix.GetLength(1) + c + 1] = matrix[r, c + 1];
                    }
                    if (r > 0)
                    {
                        graph[r * matrix.GetLength(1) + c, (r - 1) * matrix.GetLength(1) + c] = matrix[r - 1, c];
                    }
                    if (r < matrix.GetLength(0) - 1)
                    {
                        graph[r * matrix.GetLength(1) + c, (r + 1) * matrix.GetLength(1) + c] = matrix[r + 1, c];
                    }
                }
            }
        }
    }
}
