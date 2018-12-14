using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Stack.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Data d = new Data();

            Stack<Data> stack = new Stack<Data>();

            stack.Push(new Data("Bogdan"));
            stack.Push(new Data("Alex"));
            stack.Push(new Data("Daniel"));

            //foreach (var i in stack)
            //{
            //    Console.WriteLine(i.Name);
            //}
          

            stack.Pop();

            d = stack.Pop();

           Console.WriteLine(d.Name);

            Console.ReadKey();
        }
    }
}
