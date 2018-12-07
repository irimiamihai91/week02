using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 1, 5, 7, -1, 10,-4};
            int sum = 6;

            getPairs(arr, sum);
            Console.ReadKey();
        }
        public static void getPairs(int[] arr,int sum)
        {
            for (int i = 0;i < arr.Length; i++)
                for (int j = i + 1;j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == sum)

            Console.WriteLine("Pairs that have teh results 6 : " + arr[i] + " "+ arr[j]);

        }
    }
}
