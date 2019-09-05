using System;

namespace MergeTwoSortedLists6
{
    class Program
    {
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
        public class LinkedLists
        {
            public Node head;
            
            public void AddToEnd(Node node)
            {
                if (head == null)
                    head = node;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                        temp = temp.next;
                    temp.next = node;
                }
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
        }
        public static Node SortedMerge(Node head1, Node head2)
        {
            Node head = new Node(0);
            Node temp = head;
            while (true)
            {
                if (head1 == null)
                {
                    temp.next = head2;
                    break;
                }
                if (head2 == null)
                {
                    temp.next = head1;
                    break;
                }
                if (head1.data < head2.data)
                {
                    temp.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    temp.next = head2;
                    head2 = head2.next;
                }
                temp = temp.next;
            }
            return head.next;
        }
        static void Main(string[] args)
        {
            LinkedLists llist1 = new LinkedLists();
            LinkedLists llist2 = new LinkedLists();
            llist1.AddToEnd(new Node(10));
            llist1.AddToEnd(new Node(20));
            llist1.AddToEnd(new Node(30));
            Console.WriteLine("the first List elements are  :");
            llist1.Print();
            llist2.AddToEnd(new Node(15));
            llist2.AddToEnd(new Node(17));
            llist2.AddToEnd(new Node(40));
            Console.WriteLine("the second list elements are  :");
            llist2.Print();

            llist1.head = SortedMerge(llist1.head, llist2.head);

            Console.WriteLine("After sorting two lists The values are :");
            llist1.Print();
            Console.Read();
        }
    }
}
