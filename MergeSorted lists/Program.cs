using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSorted_lists
{
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
                public void  AddNode( Node node)
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
            public  Node MergeList( Node h1,Node h2 )
            {
                if (h1 == null)
                    return h2;
                if (h2 == null)
                    return h1;

                if (h1.data < h2.data)
                {
                    h1.next = MergeList(h1.next, h2);
                    return h1;
                }
                else
                {
                    h2.next = MergeList(h1, h2.next);
                    return h2;

                }
            }
            public  void PrintList()
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
                LinkedList list1 = new LinkedList();
                list1.AddNode(new LinkedList.Node(4));
                list1.AddNode(new LinkedList.Node(6));
                list1.AddNode(new LinkedList.Node(8));
                list1.AddNode(new LinkedList.Node(10));

                Console.WriteLine("Given linked list1:");
                list1.PrintList();

                LinkedList list2 = new LinkedList();
                list2.AddNode(new LinkedList.Node(5));
                list2.AddNode(new LinkedList.Node(7));
                list2.AddNode(new LinkedList.Node(9));
                list2.AddNode(new LinkedList.Node(11));
                Console.WriteLine("Given linked list2: ");
                list2.PrintList();

                LinkedList ll = new LinkedList();

               
                Node n1 =ll. MergeList(new LinkedList. Node(4), new LinkedList.Node(5));
                 Console.WriteLine("Merged sorted linked list :");
               // Node n1 = ll.MergeList(new LinkedList.Node(5), new LinkedList.Node(4));

                ll.PrintList();
                Console.ReadKey();

        }




        }
        


    }
}
