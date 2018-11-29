using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Entered number is : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("The number is even");
                Console.Read();
            }

            else
            {
                Console.Write("the number is odd");
                Console.Read();
                   
            }
        }
    }
}
