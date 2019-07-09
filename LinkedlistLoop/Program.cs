using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node(2));
            list.AddNode(new LinkedList.Node(4));
            list.AddNode(new LinkedList.Node(15));
            list.AddNode(new LinkedList.Node(20));
            list.AddNode(new LinkedList.Node(25));

            Console.WriteLine("Given linked list:");
            list.Printll();
            list.head.next.next.next.next = list.head;
       
            if(list.DetectLoop(new LinkedList.Node(2)))


                           Console.WriteLine("Loop found");
            else
                Console.WriteLine("No Loop");
            Console.ReadKey();

        }
        public class LinkedList
        {
          public   Node head;
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

            public void AddNode(Node node)
            {
                if (head == null)
                    head=node;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;

                }
            }

            public  bool DetectLoop(Node node)
            {
                var set = new HashSet<Node>();
                while (node != null)
                {
                    if (set.Contains(node))
                        return true;
                    set.Add(node);
                    node = node.next;

                }
                return false;
            }

            public void Printll()
            {
                Node curr = head;
                while (curr != null)
                {
                    Console.Write(curr.data + "  ");
                    curr = curr.next;

                }
                Console.WriteLine();

            }


        }
    }
}