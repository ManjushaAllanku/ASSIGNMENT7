using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAnticlockwiseLinkedlist
{
    class Program
    {
        // Given a singly linked list, write a function to swap elements pairwise.
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node(10));
            list.AddNode(new LinkedList.Node(20));
            list.AddNode(new LinkedList.Node(30));
            list.AddNode(new LinkedList.Node(40));
            list.AddNode(new LinkedList.Node(50));
            list.AddNode(new LinkedList.Node(60));
         

            Console.WriteLine("Given linked list:");
            list.PrintLL();

            int k = 4;

            list.RotateLL(new LinkedList.Node(2),k);
            Console.WriteLine("afater rotating anticlockwise "+ k + "  NODES");
            list.PrintLL();
            Console.ReadKey();

        }

        public class LinkedList
        {
            Node head;

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
                    head = node;
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
            public void PrintLL()
            {
                Node curr = head;
                while (curr != null)
                {
                    Console.Write(curr.data + " ");
                    curr = curr.next;
                }
                Console.WriteLine();
            }
            public void RotateLL(Node node, int k)
            {
                Node temp = head;
                int count=1;
                while(count<k && temp!=null)
                {
                    
                    temp = temp.next;
                    count++;
                }

                if (temp == null)
                    return;
                Node knode = temp;
                while(temp.next!=null)
                {
                    temp = temp.next;

                }
                temp.next = head;
                head = knode.next;
                knode.next = null;


            }

            
        }
    }

  
}
