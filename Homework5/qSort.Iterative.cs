using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5] { 4, 2, 6, 9, 2 };

            qSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.ReadKey();
        }

        public static int Partition (int []arr,int low, int high)
        {
            // this function takes last element as pivot, places the pivot element at his correct position in sorted array, and places all smaller to left and all greater to right
            int pivot = arr[high];
            int temp;
            // index of smaller element

            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                // if curent element is smaller or equal with pivot 

                if (arr[j] <= pivot)
                {
                    i++;

                    //swap arr[i] and arr[j]

                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap ar[i+1] and arr [high]
            //(or pivor)

            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            return i + 1;
        }

        public static void qSort(int[]arr, int low, int high)
        {
            // function that implements qsort
            // low > starting index
            // high > ending index

            if (low < high)
            {
                //pi is partitioning index

                int pi = Partition(arr, low, high);

                // Recursively sort elements 
                // before partition and after  
                // partition 

                qSort(arr, low, pi - 1);
                qSort(arr, pi + 1, high);


            }

        }

        
    }
}
