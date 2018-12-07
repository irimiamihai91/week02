using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;


            Console.WriteLine("Please enter a number to calculate the factorial: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial_Recursion(number));
            Console.ReadKey();
        }
        public static double factorial_Recursion(int number)
        {
            if (number == 1)
            
                return 1;
            
            else
            
                return number * factorial_Recursion(number - 1);
            
        }
    }
}
