namespace _03.GraphCycles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GraphCycles
    {
        private static HashSet<int>[] graph;
        private static StringBuilder result;
        private static bool foundCycle = false;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            graph = new HashSet<int>[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] currentParams = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                graph[int.Parse(currentParams[0])] = new HashSet<int>();
                for (int j = 1; j < currentParams.Length; j++)
                {
                    graph[int.Parse(currentParams[0])].Add(int.Parse(currentParams[j]));
                }
            }

            result = new StringBuilder();
            CheckForCycles(n);
            if (!foundCycle)
            {
                Console.WriteLine("No cycles found");
            }
            else
            {
                Console.WriteLine(result.ToString().Trim());
            }
        }

        private static void CheckForCycles(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var children = graph[i].OrderBy(x => x);
                int first = children.FirstOrDefault(x => x > i);
                if (first != 0)
                {
                    for (int j = first; j < n; j++)
                    {
                        var grandchildren = graph[j].OrderBy(x => x);
                        int second = grandchildren.FirstOrDefault(x => x > i);
                        if (second != 0)
                        {
                            for (int k = second ; k < n; k++)
                            {
                                if (graph[i].Contains(j) && graph[j].Contains(k) && graph[k].Contains(i) && j != k)
                                {
                                    result.AppendLine(string.Format("{{{0} -> {1} -> {2}}}", i, j, k));
                                    foundCycle = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
