using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = sum_of_digits(num);
            Console.WriteLine("Suma numerului " + num + " este " + result);
            Console.ReadKey();

            
        }
        public static int sum_of_digits (int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return num % 10 + sum_of_digits(num / 10);
            }
        }
    }
}
