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
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int divi = number1/number2;
            Console.WriteLine(number1 * number2);
            if (division == 0)
            {
                Console.WriteLine("The operation is not possible");

            }
            else
            {
                Console.WriteLine(divi);
                
            }
            Console.Read();

        }
    }
}