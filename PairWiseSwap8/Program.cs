using System;

namespace PairWiseSwap8
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
                Console.WriteLine("The values in list are :   ");
                while (temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            public void PairWiseSwap()
            {
                Node temp = head;
                while(temp!=null&&temp.next!=null)
                {
                    int k = temp.data;
                    temp.data = temp.next.data;
                    temp.next.data = k;
                    temp = temp.next.next;
                }
            }
        }
            static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            for (int i = 7; i >= 1; i--)
                llist.Add(i);
            llist.Print();
            llist.PairWiseSwap();
            llist.Print();
            Console.Read();
        }
    }
}
