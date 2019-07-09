using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node('m'));
            list.AddNode(new LinkedList.Node('a'));
            list.AddNode(new LinkedList.Node('d'));
            list.AddNode(new LinkedList.Node('a'));
            list.AddNode(new LinkedList.Node('m'));
           // list.AddNode(new LinkedList.Node('e'));


            Console.WriteLine("Given linked list:");
            list.Printll();
            list.Ispalindrome(new LinkedList.Node('m'));
            Console.ReadKey();

        }

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
            public  void AddNode(Node node)
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

            public  void Ispalindrome(Node node)
            {
                Node fptr = head;
                Node sptr = head;
                Node second;
                Node first;


                if (fptr.next == null)
                {
                    Console.WriteLine(" it is a palindrome");
                    return;
                }
                while (true)
                {
                    fptr = fptr.next.next;
                    if(fptr == null)
                    {
                        second = sptr.next;
                        break;
                    }
                    if (fptr.next == null)
                    {
                        second = sptr.next.next;
                        break;
                    }
                    sptr = sptr.next;

                }
                sptr.next = null;
               ReverseLL(second);
                first = head;
                while(first!=null && second != null)
                {
                    if (first.data == second.data)
                    {
                        first = first.next;
                        second = second.next;

                    }
                    else
                    {
                        Console.WriteLine(" it is not a palindrome");
                        return;

                    }

                    Console.WriteLine(" it is a palindrome");
                }

            }


            public void ReverseLL(Node node)
            {
                Node prev = null,  next = null;
                node = head;
                while (node != null)
                {
                    next = node.next;
                    node.next = prev;
                    prev = node;
                    node = next;

                }
                head = prev;

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
