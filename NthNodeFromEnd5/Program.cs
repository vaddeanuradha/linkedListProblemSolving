using System;

namespace NthNodeFromEnd5
{
    class Program
    {
        public class LinkedList
        {
            public Node head;
            public int count = 0;
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
                count++;
            }
            public void findNthNode(int n)
            {
                if (n > count)
                    Console.WriteLine("there is no Nth Node  :");
                Node temp = head;
               
                for (int i = 1; i < count - n + 1;i++)
                  temp = temp.next;
                Console.WriteLine("The nth Node from the End is  :  " + temp.data);
                
            }
            public void Print()
            {
                Node temp = head;
                Console.WriteLine("List is  :  ");
                while(temp!=null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.Add(10);
            llist.Add(20);
            llist.Add(30);
            llist.Add(40);
            llist.Add(50);
            llist.Add(60);

            llist.Print();
            llist.findNthNode(4);
            Console.Read();
        }
    }
}
