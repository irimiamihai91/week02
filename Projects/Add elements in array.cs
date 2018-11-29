using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 17, 2, 7, 2, 8 };
            int value = 2;
            int index = 3;

            int [] newArray = new int[arr.Length + 1];

            int counter = 0;

            for(int i =0;i <= arr.Length; i++)
            {
                if(i == index)// i egal cu index
                {
                    newArray[i] = value;// inseram elementul la indexul celui deal doilea index
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i - counter];
                }
            }
            for(int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
