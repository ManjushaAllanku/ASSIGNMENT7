using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapElements
{
    //Given a singly linked list, write a function to swap elements pairwise.
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node(10));
            list.AddNode(new LinkedList.Node(20));
            list.AddNode(new LinkedList.Node(30));
            list.AddNode(new LinkedList.Node(40));
            list.AddNode(new LinkedList.Node(50));
            list.AddNode(new LinkedList.Node(60));
            list.AddNode(new LinkedList.Node(70));
            list.AddNode(new LinkedList.Node(80));
            list.AddNode(new LinkedList.Node(90));
            list.AddNode(new LinkedList.Node(100));




            Console.WriteLine("Given linked list:");
            list.PrintList();
            list.pairWiseSwap();
            Console.WriteLine(" linked list after swapping elements");
                        list.PrintList();
            Console.ReadKey();

        }


       public class LinkedList
        {
            Node head;
            public class  Node
            {
                public int data;
                public Node next;
                public Node(int d)
                {
                    data = d;
                    next = null;

                }
            }

            public void  AddNode(Node node)
            {

                if (head== null)
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

            public void PrintList()
            {
                Node curr = head;
                while (curr != null)
                {
                    Console.Write(curr.data + " ");
                    curr = curr.next;
                }
                Console.WriteLine();

            }

           public  void pairWiseSwap()
            {
                Node temp = head;

                while (temp != null && temp.next != null)
                {
                    int k = temp.data;
                    temp.data = temp.next.data;
                    temp.next.data = k;
                    temp = temp.next.next;
                }
            }
        }
    }
}
