using System;

namespace SumOfLinkedList9
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
        public class LinkedList
        {
            public Node head;
            public void Add(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;
            }
            public void Print()
            {
                Node temp = head;
                Console.WriteLine("The values in list is  :");
                while(temp!=null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
           
            
        }
        public static Node AddTwoLists(Node node1, Node node2)
        {
            Node prev = null;
            Node res = null;
            Node cur = null;
            int carry = 0, sum;
            while (node1 != null || node2 != null)
            {
                sum = carry + (node1 != null ? node1.data : 0) + (node2 != null ? node2.data : 0);
                carry = (sum >= 10) ? 1 : 0;
                sum = sum % 10;
                cur = new Node(sum);
                if (res == null)
                    res = cur;
                else
                    prev.next = cur;
                prev = cur;
                if (node1 != null)
                    node1 = node1.next;
                if (node2 != null)
                    node2 = node2.next;
            }
            if (carry > 0)
                cur.next = new Node(carry);
            return res;
        }
        static void Main(string[] args)
        {
            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();

            LinkedList resList = new LinkedList();

            llist1.Add(4);
            llist1.Add(5);

            llist1.Print();

            llist2.Add(3);
            llist2.Add(4);
            llist2.Add(5);

            llist2.Print();
            resList.head = AddTwoLists(llist1.head, llist2.head);
            resList.Print();

            Console.Read();

        }
    }
}
