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
            Console.WriteLine("The temperature in farenhait to celsius: ");
            int fah = int.Parse(Console.ReadLine());

            
            int FtoC = ((fah - 32) / 9) * 5;
            Console.WriteLine("dsdasda" + FtoC);
            Console.ReadKey();
        }
    }
}