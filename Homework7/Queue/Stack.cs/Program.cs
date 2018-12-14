using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Queue

{
    class Program
    {
        static void Main(string[] args)
        {





            Queue<int> queue = new Queue<int>();

            queue.Enqueue((1));
            queue.Enqueue((2));
            queue.Enqueue((2));


            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            queue.Dequeue();

            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
