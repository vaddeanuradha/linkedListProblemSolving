using System;

namespace RotateKnodesCounterClock2
{
    class Program
    {
        public class LinkedList
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
            public void Add(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;
            }
            public void Print()
            {
                Node temp = head;
                while(temp!=null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            public void Rotate(int k)
            {
                if (k == 0)
                    return;
                Node current = head;
                int count = 1;
                while(count<k&&current!=null)
                {
                    current = current.next;
                    count++;
                }
                if (current == null)
                    return;
                Node KthNode = current;
                while (current.next != null)
                    current = current.next;
                current.next = head;
                head = KthNode.next;
                KthNode.next = null;

            }
        }
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            for (int i = 60; i >= 10; i -= 10)
                llist.Add(i);

            llist.Print();
            Console.WriteLine("After rotating the values of list are:");
            llist.Rotate(4);
            llist.Print();
            Console.Read();
        }
    }
}
