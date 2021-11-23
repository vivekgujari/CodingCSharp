using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.DataStructures
{
    public class Graph
    {
        private class Node
        {
            public string label;
            public Node(string label)
            {
                this.label = label;
            }
        }

        Dictionary<Node, List<Node>> graph;
        Dictionary<string, Node> nodes;

        public void print()
        {
            foreach (var key in graph.Keys)
            {
                
                Console.Write(key.label + "->");
                graph[key].ForEach(m => Console.Write(m.label + " "));
                Console.WriteLine();
            }
        }
        public Graph()
        {
            this.nodes = new Dictionary<string, Node>();
            this.graph = new Dictionary<Node, List<Node>>();
        }

        public void addNode(string label)
        {
            if (label.Length == 0 || label == null)
                return;
            if (this.nodes.ContainsKey(label))
                return;
            this.nodes.Add(label, new Node(label));
            graph.Add(nodes[label], new List<Node>());
        }


        public void addEdge(string to, string from)
        {
            Node toNode = null, fromNode = null;
            if (nodes.ContainsKey(to) && nodes.ContainsKey(from))
            {
                toNode = nodes[to];
                fromNode = nodes[from];
            }
            else
            {
                return;
            }

            graph[fromNode].Add(toNode);
            graph[toNode].Add(fromNode);
        }
        public void removeNode(string label)
        {
            if (label.Length == 0 || label == null)
                return;

            Node n = nodes[label];
            if (n == null)
                return;

            foreach (var key in graph.Keys)
            {
                graph[key].Remove(n);
            }
            nodes.Remove(label);
            graph.Remove(n);
        }

        public void removeEdge(string from, string to)
        {
            Node fromNode = nodes[from];
            Node toNode = nodes[to];
            if (fromNode == null || toNode == null)
                return;
            graph[fromNode].Remove(toNode);
        }

        public void DepthFirstTraversal(string node)
        {
            HashSet<Node> set = new HashSet<Node>();
            DFT(nodes[node], set);
            foreach(var item in set)
                Console.WriteLine(item.label);
        }

        private void DFT(Node node, HashSet<Node> set)
        {
            if (node == null)
                return;
            if (set.Contains(node))
                return;

            set.Add(node);

            foreach (var n in graph[node])
            {
                DFT(n, set);
            }
        }

    }
}
