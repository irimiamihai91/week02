using System ;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main (string []args)
        {
        
        int [] number = new int [10];

        for (int i = 0; i<10 ; i++){

            number[i] = i+10;

            if(i==9)
            {
                Console.Write(number[i]);

            }
            else
            {
                Console.Write(number[i] + ",");

            }
        }
        
        Console.ReadKey();
        }
        

        }

    }

