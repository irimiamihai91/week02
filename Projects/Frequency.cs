using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 43, 12, 32, 22, 23, 22 };
            Console.WriteLine("Array { 43, 12, 32, 21, 23, 22 } \n");
            GetFrequency(array);
            Console.ReadKey();
        }

        private static void GetFrequency(int[] array)
        {
            var dict = new Dictionary<int, int>();
            foreach (int value in array)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }
                foreach (var kvp in dict)
                {
                    Console.WriteLine(kvp.Key + " ocured " + kvp.Value + " times ");
                }
            }
        }
    }

