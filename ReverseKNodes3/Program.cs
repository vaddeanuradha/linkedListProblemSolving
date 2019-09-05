using System;

namespace ReverseKNodes3
{
    class Program
    {
        public class LinkedList
        {
            public Node head;
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
                while (temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            public Node Reverse(Node head,int k)
            {
                Node current = head;
                Node next = null;
                Node prev = null;
                int count = 0;
                while(count<k&&current!=null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                    count++;
                }
                if (next != null)
                    head.next = Reverse(next, k);
                return prev;

            }
        }
            static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            for (int i = 9; i >= 1; i--)
                llist.Add(i);
            llist.Print();

            llist.head = llist.Reverse(llist.head, 3);
            Console.WriteLine("the Reverse list is :");
            llist.Print();
            Console.Read();

        }
    }
}
