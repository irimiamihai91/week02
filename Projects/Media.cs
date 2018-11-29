using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22

{
    
        
    }
    class Program
    {


    public static int FindIndex(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }
        return -1;

    }
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 17, 2, 7 };
            int value = 2;

            var index = FindIndex(arr, value);
        int [] newArray = new int[arr.Length -1];

        int counter = -1;

        for (int i = 0;i<arr.Length; i++)
        {
            if (i == index)
            {
                continue;
            }
            counter++; // crestem counterul pentru a pleca de la indexul 0 in noul array
            newArray[counter] = arr[i];
        }
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i] + " , ");
        }
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }


