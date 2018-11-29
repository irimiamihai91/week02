using System ;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main (string []args)
        {
            int[] numbers = new int[5];
            numbers [0] = 10;
            numbers [1] = 11;
            numbers [2] = 13;
            numbers [3] = 14;
            numbers [4] = 15;

            int[] aux = new int[numbers.Length];
            
            for(int i = numbers.Length-1; i >=0; i--)
             
            {   
                int index = numbers.Length-i-1;
                aux[index] = numbers[i];

                
            }
            WriteNumbers (aux);
            
            Console.ReadKey();

        }

        public static void WriteNumbers(int [] array)
        
        {
            for (int i = 0;i<=aux.Length-1;i++)
            {
            
             if (i == aux.Length-1){
                
                Console.WriteLine(aux[i] );
                }
                else
                {

                    Console.WriteLine(aux[i] + ",");
                }

            }
        }

    }

 }

