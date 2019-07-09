using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseKnodes
{
    //Given a linked list, write a function to reverse every k nodes (where k is an input to the function).
    //If a linked list is given as 1->2->3->4->5->6->7->8->NULL and k = 3 then output will be 3->2->1->6->5->4->8->7->NULL.

    class Program
    {
        
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

            public void RevKNodes(Node node, int k)
            {    
                Node curr =head;
                Node prev = null;
                Node next = null;
                int counter = 0;
               
                while(counter<k && curr != null)
                {

                    next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                   counter++;
                }
                                 
               if ( next != null)
            
                RevKNodes(head.next, k);
            

                head = prev;
                

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
                list.PrintLL();

                int k = 4;

                list.RevKNodes(list.head,k);
                Console.WriteLine("after reversing " + k + " NODES");
                list.PrintLL();
                Console.ReadKey();
            }

        }
    }
}