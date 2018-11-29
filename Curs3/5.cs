using System ;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main (string []args)
        {
        Console.WriteLine("Introduceti sirul de caractere");
         var s = Console.Read();

         var arr = s.ToCharArray();

         for (var i  = arr.Lenght - 1; i >= 0 ; i --){

             Console.WriteLine(arr[i] );
         }

         //Console.WriteLine(s.Reverse()); //intoarce dintr-un pas un sir de caractere

         Console.ReadLine();

        }

        }

    }

