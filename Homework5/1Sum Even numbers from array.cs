using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvenNumbers
{
    class Program
    {

        public static void Main()
        {
           
            int[] arr = { 1, 2, 3, 4, 5, 6 , 8,2};

            sumEven(arr);
            Console.ReadKey();
 
        }
        public static void sumEven(int[] arr)
        {
            int even = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += arr[i];
                }
            }
            Console.WriteLine("Suma elementelor pare din array { 1, 2, 3, 4, 5, 6 , 8} este " + even);
        }
        
       }
    }


