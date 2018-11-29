using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Module2._1_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[6]{43, 12, 32, 21, 23, 22 };

            //Sum
            int sum = Sum(array);
            Console.WriteLine("Suma elementelor din array este : "  + sum);
            //Average
            double average = Average(array);
            Console.WriteLine("Media aritmetica a elementelor din array este : " + average);

            //Verificam indexul uni element
            Console.WriteLine("Introduceti numarul pentru a afla la ce index se gaseste : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Boolean found = false;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i].Equals(a))
                {
                    Console.WriteLine("Elementul: "+ a +" a fost gasit la indexul " + i);
                    found = true;
                    break;
                }
            }
                if (!found)
                {
                    Console.WriteLine("Elementul respectiv nu a fost gasit");
                }
                Console.ReadKey();

            
          

        }

        public static int Sum( int []array )
        {
            int sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                sum =sum + array[i];
            }

            return sum;

        }

        public static double Average(int [] array)
        {
            double sum = Sum(array);
            double size = array.Length;
            double average = sum / size;
            return average;
        }
        
        }

    }



