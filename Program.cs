using System;
using System.Collections.Generic;
using Coding.DataStructures;
using Coding.Sorting;
using DataStructures;
namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingStacks queue = new QueueUsingStacks();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            int a = queue.Deque();
            int b = queue.Deque();
            Console.WriteLine($"{a} {b}");
            Console.WriteLine("End of main program");
            Console.ReadKey();
        }
    }
}
