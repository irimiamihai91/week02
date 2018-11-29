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

            int x;

            for(int i = 0;i<numbers.Length/2;i++)
            {
                
               
                Swap (numbers , i , numbers.Length-i-1 );
            }

            WriteNumbers(numbers );
               Console.ReadLine ();
        }
        
        public static void Swap(int[] arr,int i , int j)
        {
            var x = arr[i];
            arr[i] = arr [ j];
            arr[j] = x;

        }


        public static void WriteNumbers(int [] aux)
        
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

        

    

