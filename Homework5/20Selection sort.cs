using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 64, 25, 12, 22, 11 };
            Sort(arr);
            printArray(arr);
            Console.ReadKey();
        }

        public static void Sort(int [] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_index = i;

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[min_index])
                    {

                        min_index = j;

                        int temp = arr[min_index];
                        arr[min_index] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        public static void printArray(int [] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
    }
}
