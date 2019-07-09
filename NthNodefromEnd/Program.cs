using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthNodefromEnd
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

            public void NthnodefronLast(Node node, int n)
            {
                Node Sptr = head;
                Node Fptr = head;
                int ctr = 0;
                if (head != null)
                {
                    while (ctr < n )
                    {
                        Fptr = Fptr.next;
                        ctr ++;
                    } 
                    while (Fptr.next != null)
                    {
                        Sptr = Sptr.next;
                        Fptr = Fptr.next;

                    }
                    Console.WriteLine(n + "node from end is " + Sptr.next.data);

              

                }
            }
            public static void Main(string[] args)
            {
                LinkedList list = new LinkedList();
                list.AddNode(new LinkedList.Node(2));
                list.AddNode(new LinkedList.Node(4));
                list.AddNode(new LinkedList.Node(15));
                list.AddNode(new LinkedList.Node(25));
                list.AddNode(new LinkedList.Node(30));
                list.AddNode(new LinkedList.Node(35));
                list.AddNode(new LinkedList.Node(40));
                list.AddNode(new LinkedList.Node(45));
                list.AddNode(new LinkedList.Node(50));


                Console.WriteLine("Given linkedlist is ");
                list.PrintLL();
                int k = 4;

            
                list.NthnodefronLast(new LinkedList.Node(2), k);
              

                Console.ReadKey();


            }



        }
    }
}
