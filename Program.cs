using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    
    public class MyLinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) 
            {
                data = d;
                next = null;
            }
        }

        public MyLinkedList() 
        {
            this.head = null;
        }

    }
}
