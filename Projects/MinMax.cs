using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 43, 12, 32, 21, 23, 22 };
            
            int min = array[0];
            int max = array[0];

            for(int i = 1; i <= array.Length-1; i++)
            {
                if (min > array[i])
                {
                    min = array[i];

                }
                if (max < array[i])
                {
                    max = array[i];
                }
                Console.WriteLine("Max " + max);
                Console.WriteLine("Min " + min);
                Console.ReadLine();
            }
            

        }
        

    }
}
