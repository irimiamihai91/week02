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
            int val1 = 10, val2 = 2;
            
            Console.WriteLine(val1 * val2);
            if (val1/val2 == 0)
            {
                Console.WriteLine("The operation is not possible");

            }
            else
            {
                Console.WriteLine(val1/val2);
                
            }
            Console.Read();

        }
    }
}