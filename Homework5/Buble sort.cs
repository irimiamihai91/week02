using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 7, 1, 9 };

            for (int i=0; i < arr.Length; i++)
            {
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Sawp(arr, i, j);
                    }
                }
            }
            foreach(var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.ReadKey();
        }

        public static void Sawp(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
            
        }
    }
}
