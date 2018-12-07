using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int factorial = 0;
            int counter = 0;

            Console.WriteLine("Please enter a number to calculate the factorial: ");
            number = Convert.ToInt32(Console.ReadLine());

            factorial = number;
            counter = number - 1;

            while (counter > 0)
            {
                factorial *= counter;
                counter--;
            }
            Console.WriteLine("Factorial of " + number + " is " + factorial);
            Console.ReadKey();
        }
    }
}
