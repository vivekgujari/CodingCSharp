using System;
using System.Collections.Generic;
using Coding.DataStructures;
using DataStructures;
namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph G = new Graph();
            G.addNode("A");
            G.addNode("B");
            G.addNode("C");
            G.addEdge("B", "A");
            G.addEdge("C", "A");
            G.addNode("D");
            G.addNode("E");
            G.addEdge("A", "E");
            G.DepthFirstTraversal("A");
            Console.WriteLine("End of main program");
            
            Console.ReadKey();
        }
    }
}
