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
            int[] numbers = new int[20];


            for (int i = 0; i < 20; i++)
            {
                numbers[i] = i +30;
                if(i == 19)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ",");
                }
            }
            Console.ReadKey();
        }
    }
}
