using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy 
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[6] { 43, 12, 32, 21, 23, 22 };
            int[] target = new int[6];

            Array.Copy(array, target, 6);

            Console.WriteLine("-----Traget array-----");

            foreach(int value in target)
            {
                if (value == target.Length-1)
                {
                    Console.Write(value);
                }
                else
                {
                    Console.Write(value + " , ");
                }
            }
            Console.ReadLine();
           
            }
        }
    }

