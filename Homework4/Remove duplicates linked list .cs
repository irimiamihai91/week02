using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp33
    {
        class Program
        {
            static void Main(string[] args)
            {
                LinkedList<int> list = new LinkedList<int>();

                LinkedListNode<int> FirstNode = list.AddFirst(10);
                LinkedListNode<int> SecondNode = list.AddAfter(FirstNode, 20);
                LinkedListNode<int> ThirdNode = list.AddAfter(SecondNode, 30);
                LinkedListNode<int> ForthdNode = list.AddAfter(ThirdNode, 30);
                
                for (int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i + 1; j <list.Count; j++)
                {
                    var firstEl = list.ElementAt(i);
                    var secondEl = list.ElementAt(j);

                    if (firstEl == secondEl)
                    {
                        list.Remove(firstEl);
                    }
                }
            }


                foreach (var node in list)
                {
                    Console.Write(node + ",");

                }
                Console.ReadKey();
            }
        }
    }

