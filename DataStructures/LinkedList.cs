using System;

namespace DataStructures
{
    public class LinkedList
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node(int val)
            {
                this.val = val;
                this.next = null;
            }
        }

        public Node head;
        public int size = 0;
        public void insert(int item)
        {
            if (head == null)
            {
                head = new Node(item);
                size++;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new Node(item);
            size++;
        }

        public void swap()
        {
            if (size < 2)
                return;

            Node temp = head;
            while (temp != null && temp.next != null)
            {
                int k = temp.val;
                temp.val = temp.next.val;
                temp.next.val = k;
                temp = temp.next.next;
            }
        }
    }
}
