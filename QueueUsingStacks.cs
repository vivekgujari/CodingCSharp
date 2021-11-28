using System;
using System.Collections.Generic;
using System.Text;

namespace Coding
{
    public class QueueUsingStacks
    {
        public Stack<int> s1;
        public Stack<int> s2;
        public int size;

        public QueueUsingStacks()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
            size = 0;
        }

        public void Enqueue(int item)
        {
            while (s2.Count != 0)
                s1.Push(s2.Pop());

            s1.Push(item);
            size++;
        }

        public int Deque()
        {
            if (size == 0)
                throw new Exception("Queue has no data to deque");
            
            while (s1.Count != 0)
                s2.Push(s1.Pop());

            int item = s2.Pop();
            size--;
            return item;
        }
    }
}
