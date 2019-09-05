using System;

namespace CheckLishHasLoop4
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
            public bool findLoop()
            {
                if (head.next == null)
                    Console.WriteLine("there is no loop  : ");
                Node sp = head.next, fp = head.next.next;
                while (fp != null && fp.next != null)
                {
                    if (sp == fp)
                        return true;
                    sp = sp.next;
                    fp = fp.next.next;
                }
                return false;
            }
            public void Add(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;
            }
        }
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.Add(1);
            llist.Add(2);
            llist.Add(3);
            llist.Add(4);
            llist.Add(5);

            llist.head.next.next.next.next = llist.head.next;

            if (llist.findLoop())
                Console.WriteLine("Fount loop: ");
            else
                Console.WriteLine("There is no loop  :");
            Console.Read();
        }
    }
}
