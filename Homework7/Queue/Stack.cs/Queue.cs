using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue

{
    class Queue
    {
         
         private Node head;
        private Node tail;
        private int count = 0;
        public Queue() { }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                tail = tail.Next;
            }
            count++;
        }
        public int Dequeue()
        {
            if (head == null)
            {
                throw new Exception("Queue is Empty");
            }
            int result = head.Data;
            head = head.Next;
            return result;
        }


    }

   
    }

