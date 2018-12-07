using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");
            string message = Console.ReadLine();

            char[] arr = message.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            if (message.ToLower().Equals(reversed.ToLower())) 
            {
                Console.WriteLine("The word entered is palindrome");
            }
            else{
                Console.WriteLine("The word enetered is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
