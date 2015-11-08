using System;
using System.Collections.Generic;
using System.Linq;

public class TopologicalSorter
{
    private Dictionary<string, List<string>> graph;

    private HashSet<string> visitedNodes;

    private LinkedList<string> sortedNodes;

    private HashSet<string> cycleNodes;

    public TopologicalSorter(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    public IEnumerable<string> TopSort()
    {
        this.visitedNodes = new HashSet<string>();
        this.sortedNodes = new LinkedList<string>();
        this.cycleNodes = new HashSet<string>();

        foreach (var node in graph.Keys)
        {
            TopSortDFS(node);
        }

        return this.sortedNodes;

        //var predecessorsCount = new Dictionary<string, int>();
        //foreach (var node in this.graph)
        //{
        //    if (!predecessorsCount.ContainsKey(node.Key))
        //    {
        //        predecessorsCount[node.Key] = 0;
        //    }
        //    foreach (var childNode in node.Value)
        //    {
        //        if (!predecessorsCount.ContainsKey(childNode))
        //        {
        //            predecessorsCount[childNode] = 0;
        //        }

        //        predecessorsCount[childNode]++;
        //    }
        //}

        //var removeNodes = new List<string>();
        //while (true)
        //{
        //    string nodeToRemove = graph.Keys.FirstOrDefault(n => predecessorsCount[n] == 0);
        //    if (nodeToRemove == null)
        //    {
        //        break;
        //    }

        //    foreach (var childNode in graph[nodeToRemove])
        //    {
        //        predecessorsCount[childNode]--;
        //    }
        //    graph.Remove(nodeToRemove);
        //    removeNodes.Add(nodeToRemove);

        //}

        //if (graph.Count > 0)
        //{
        //    throw new InvalidOperationException("A cycle detected in the graph");
        //}

        //return removeNodes;
    }

    private void TopSortDFS(string node)
    {
        if (this.cycleNodes.Contains(node))
        {
            throw new InvalidOperationException("A cycle detected in the graph!");
        }

        if (!this.visitedNodes.Contains(node))
        {
            this.visitedNodes.Add(node);
            this.cycleNodes.Add(node);

            if (graph.ContainsKey(node))
            {
                foreach (var child in graph[node])
                {
                    TopSortDFS(child);
                }
            }

            this.cycleNodes.Remove(node);
            this.sortedNodes.AddFirst(node);
        }
    }
}
