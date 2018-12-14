using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.cs
{
    class Stack
    {
        private Node Top;

        public void Push(Data d)
        {
            Node tempNode = new Node();
            tempNode.Data = d;

            tempNode.Next = Top;

            Top = tempNode;
        }

        public Data Pop()
        {
            if (Top == null)
            {
                return null;
            }
            Node Popped = Top;

            Top = Top.Next;

            Popped.Next = null;

            return Popped.Data;
        }

        public Data Peak()
        {
            return Top.Data;

            
        }
    }
}
