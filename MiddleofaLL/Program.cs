using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleofaLL
{
    class Program
    {
            

        public class LinkedList
        {
            Node head;
            public class Node
            {
              public   int data;
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
             
            public  void MidLL(Node head)
            {

                if (head == null || head.next == null)
                    return;
                Node slowp = head;
                Node Fastp = head;
                while(slowp.next!=null && Fastp.next.next!=null)
                {
                    slowp = slowp.next;
                    Fastp = Fastp.next.next;

                }

                Console.WriteLine(" middle of linked list is " + slowp.data);
          

            }

            public void Printll()
            {
                Node curr = head;
                while (curr != null)
                {
                    Console.Write(curr.data + " ");
                    curr = curr.next;

                }
                Console.WriteLine();


            }


           public  static void Main(string[] args)
            {
                LinkedList list = new LinkedList();
                list.AddNode(new LinkedList.Node(2));
                list.AddNode(new LinkedList.Node(4));
                list.AddNode(new LinkedList.Node(15));
                list.AddNode(new LinkedList.Node(20));
                list.AddNode(new LinkedList.Node(25));


                Console.WriteLine("Given linked list:");

                list.Printll();

              //  Console.WriteLine("middel of linkedlist is ");

               list.MidLL(new LinkedList.Node(2));
           
                Console.ReadKey();
            }
        }
    }
}
