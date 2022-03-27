using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to LinkedList;");
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(56);
            list.Insert(1, 30);
            list.Display();
        }
    }
}
