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

        public bool Append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                Console.WriteLine("{0} Appended", n.data);
                return true;
            }
            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            Console.WriteLine("{0} Appended", n.data);
            return true;
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
