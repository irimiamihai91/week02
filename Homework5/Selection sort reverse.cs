using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write(array[i] + ",");
            }
            
            Console.WriteLine("n/...........................................");
            Sort(array);
            printArray(array);
            Console.ReadKey();
        }

        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i]=array[j];
                        array[j] = temp;
                    }
                }
             
            }
        }
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
        }

        public static void Fill()
        {
            Random rnd = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.Write(array[i] + ",");
            }
        }
    }
}
