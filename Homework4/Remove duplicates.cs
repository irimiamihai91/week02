using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();//{6, 1, 2, 2, 3, 5, 6, 3, 1, 5, 4, 7 };
            list.Add(new Node(6));
            list.Add(new Node(1));
            list.Add(new Node(2));
            list.Add(new Node(2));
            list.Add(new Node(3));
            list.Add(new Node(5));
            list.Add(new Node(6));
            list.Add(new Node(3));
            list.Add(new Node(1));
            list.Add(new Node(5));
            list.Add(new Node(4));
            list.Add(new Node(7));
            
            list.PrintNodes();
            list.RemoveDuplicatesFromUnsortedList();
            Console.ReadKey();
            
        }
        public class Node
        {
            public object data;
            public Node next;
            public Node(object data)
            {
                this.data = data;
            }
        }

        public class LinkedList
        {
            Node head;
            Node current;
            public void Add(Node n)
            {
                if (head == null)
                {
                    head = n; //points head to first added node
                    current = head; //set current to head
                }
                else
                {
                    current.next = n; //set current next to newly added node
                    current = current.next; // set new current to current next.
                }
            }

            public void RemoveDuplicatesFromUnsortedList()
            {
                current = head;
                {
                    while(current != null)
                    {
                        Node n = current;
                        while(n.next != null)
                        {
                            if(current.data == n.next.data)
                            {
                                n.next = n.next.next;
                            }
                            else
                            {
                                
                                n = n.next;

                            }
                        }
                        current = current.next;
                       
                        
                    }
                }
            }
            public void PrintNodes()
            {
                while(head != null)
                {
                    Console.WriteLine(head.data);
                    head = head.next;
                }
            }

            public Node FindNode(object item)
            {
                Node compared = head; // Assign the compared node to head
                while(compared !=null) // if it has reached null, it means that we have traversed the whole list without finding it
                {
                    if (compared.data != item) // if the current node data is not equeal to our item, move ahead
                    {
                        compared = compared.next;
                    }
                    else
                        return compared; // Node is found.Return it.

                }
                return compared; // if it reaches the last node and still the object is not found null will be returned.
            }

            private Node FindPrevious(object item)
            {
                Node removed = head;

                while(removed.next !=null)
                {
                    if (removed.next.data != item)
                    {
                        removed = removed.next;
                    }
                    else
                        return removed;
                }
                return removed;
            }

            private void Remove(object item)
            {
                // check if it is the first node
                if(head.data == item)
                {
                    head = head.next;

                }
                else
                {
                    Node removed = FindPrevious(item);
                    if (removed.next != null)
                        removed.next = removed.next.next;
                    else
                        Console.WriteLine("The given element is not in the list");
                }
            }

            public void ReverseList()
            {
                Node t = head; // Temporary node to store
                Node back = null; //node of reversed list
                current = head;
                while (current != null)
                {
                    t = current.next; // store the next node in t
                    current.next = back;
                    back = current;
                    current = t;
                }
                head = back; // again assign head to the new list
            }
        }



    }
    }



