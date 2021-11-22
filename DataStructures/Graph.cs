using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.DataStructures
{
    public class Graph
    {
        private class Node
        {
            string label;
            public Node(string label)
            {
                this.label = label;
            }
        }

        Dictionary<Node, LinkedList<Node>> graph;
        public Graph()
        {
            this.graph = new Dictionary<Node, LinkedList<Node>>();
        }

        public void addNode(string label)
        {
            if (label.Length == 0 || label == null)
                return;
            this.graph.Add(new Node(label), new LinkedList<Node>());
        }

        public void removeNode(string label)
        {
            if (label.Length == 0 || label == null)
                return;

            
        }
    }
}
