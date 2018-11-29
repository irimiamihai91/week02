using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 43, 12, 32, 21, 23, 22 };
            int[] aux = new int[6] { 11,14,17,12,43,15 };
            Console.WriteLine("Se afiseaza elementele comune intre { 43, 12, 32, 21, 23, 22 } si { 11,14,17,12,43,15 } ");
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < aux.Length; j++)
                {
                    if (array[i] == aux[j])
                    {
                        
                        Console.WriteLine(array[i]);
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
