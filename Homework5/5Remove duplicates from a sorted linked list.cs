using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> First = list.AddFirst(10);
            LinkedListNode<int> Second = list.AddAfter(First, 20);
            LinkedListNode<int> Third = list.AddAfter(Second, 20);
            LinkedListNode<int> Forth = list.AddAfter(Third, 40);
            LinkedListNode<int> Fifth = list.AddAfter(Forth, 50);

            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i+1; j < list.Count; j++)
                {
                    var FirstEl = list.ElementAt(i);
                    var SecondEl = list.ElementAt(j);
                    if(FirstEl == SecondEl)
                    {
                        list.Remove(FirstEl);
                    }
                }
            }
            printEl(list);
            Console.ReadKey();



        }

        private static void printEl(LinkedList<int> list)
        {
            foreach(var el in list)
            {
                Console.Write(el + ",");
            }
        }
    }
}
