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


        public bool Delete(int input)
        {
            if (head == null)
            {
                return false;
            }
            if (head.next == null)
            {
                head = null;
            }

            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data == input)
                {
                    pre.next = t.next;
                    Console.WriteLine("{0} data has been deleted from linked List", input);
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
            throw new NullReferenceException("index is not in range");
        }

        public int Size()
        {
            if (head == null)
            {
                return 0;
            }
            Node t = head;
            int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;

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
