using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static int counter;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    counter++;
                }
            }

            if (0 < counter && counter < 3)
            {
                Console.WriteLine(a + " is a prime number");
            }
            else
            {
                Console.WriteLine(a + " is not a prime number");
            }
            Console.ReadKey();

        }
    }
}
