using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 43, 12, 32, 21, 23, 22 };

            Console.WriteLine("Introduceti numarul ce se doreste a fi sters: ");

            int value = Convert.ToInt32(Console.ReadLine());

            int[] aux = new int[array.Length - 1];
                   
            bool varianta = false;

            int index = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (value == array[i])
                {
                    varianta = true;
                    continue;
                }
                else if (index >= aux.Length)
                {
                    break;
                }
                else
                {
                    aux[index] = array[i];
                    index++;
                }
            }

            if (varianta)
            {
                WriteNumbers(aux);
            }
           

            Console.ReadLine();
        }

        public static void WriteNumbers(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }
            }
        }
    }
}
