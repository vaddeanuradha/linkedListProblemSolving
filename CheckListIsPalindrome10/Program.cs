using System;
using System.Collections;

namespace CheckListIsPalindrome10
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
                Node temp = new Node(new_data);
                temp.next = head;
                head = temp;
            }
            public void Print()
            {
                Node temp = head;
                Console.WriteLine("the values in the list are:");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
            public static bool IsPalindrome(Node head)
            {
                Node temp = head;
                bool ispalin = false;
                Stack st = new Stack();
                while (temp != null)
                {
                    st.Push(temp.data);
                    temp = temp.next;
                }
                while (head != null)
                {
                    int ele = (int)st.Pop();
                if (head.data == ele)
                    ispalin = true;
                else
                {
                    ispalin = false;
                    break;
                }
                    head = head.next;

                }
                return ispalin;
            }
        
        static void Main(string[] args)
        {
                LinkedList llist = new LinkedList();
                llist.Add(1);
                llist.Add(2);
                llist.Add(2);
                llist.Add(1);

                llist.Print();

            if (IsPalindrome(llist.head))
                Console.WriteLine("The list is palindrome");
            else
                Console.WriteLine("the list is not a palindrome");
            Console.Read();
        }
    }
}
