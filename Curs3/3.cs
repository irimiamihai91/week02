using System ;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main (string []args)
        {
         for (var i = 1400; i<=2300; i++)
         {
             if((i%7==0) && (i%5==0))
             {
                 Console.WriteLine(i);
             }

         }
         Console.ReadLine();

        }

        }

    }

