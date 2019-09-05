using System;
using System.Collections.Generic;


namespace FindMidNode1
{
    class Program
    {
       public class Node
       {
            public int key;
            public Node next;
            public Node(int k, Node nextNode)
            {
                key = k;
                next = nextNode;
            }
        }
        public static int FindMidValue(Node head)
        {
            Node sp = head;
            Node fp = head;
            if (head == null && head.next == null)
                return 0;
            while(fp!=null&&fp.next!=null)
                {
                    sp = sp.next;
                    fp = fp.next.next;
                }
            return sp.key;
        }

        static void Main(string[] args)
        {
            Node node6 = new Node(6,null);
            Node node5 = new Node(5,node6);
            Node node4 = new Node(4, node5);
            Node node3 = new Node(3, node4);
            Node node2 = new Node(2, node3);
            Node node1 = new Node(1, node2);
            int midval = FindMidValue(node1);
            if (midval == 0)
                Console.WriteLine("there is no mid value: ");
            else
                Console.WriteLine("The mid element is : " + midval);
            Console.Read();
        }
    }
}
