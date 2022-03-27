using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }



    public class LinkedList
    {
        internal Node head;

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                Console.WriteLine("{0} is Added into the link list", n.data);
                return true;
            }
            else
            {
                n.next = head;
                head = n;
                Console.WriteLine("{0} is Added into the link list", n.data);
                return true;
            }
        }

        public bool Insert(int index, int data)
        {
            Node n = new Node(data);
            if (index == 0)
            {
                n.next = head.next;
                head = n;
                Console.WriteLine("{0} is inserted into Linkedlist", n.data);
                return true;
            }

            Node t = head, pre = null;
            while (index > 0 && t != null)
            {
                index--;
                pre = t;
                t = t.next;
            }
            if (index == 0)
            {
                pre.next = n;
                n.next = t;
                Console.WriteLine("{0} is inserted into LinkedList", n.data);
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }

        public void Display()
        {
            Console.WriteLine("Displaying the LinkedList elements");
            Node t = head;
            if (t == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.data + " ");
                t = t.next;
            }
        }
    }
}
