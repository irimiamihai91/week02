using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            for (int i = numbers.Length - 1;i>=0;i--)
            {
                if (i == 0)
                {
                    Console.Write(numbers[i]);
                }

                else
                {
                    Console.Write(numbers[i] + ",");
                }

            }
            Console.ReadLine();
        }
    }
}
