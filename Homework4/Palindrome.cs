using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Steps 
            // Ask the user to enter a string
            // Reverse that string and store it in a variable
            // Compare the 2 strings

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            char[] array = word.ToCharArray();

            Array.Reverse(array);

            string reversedWord = new string(array);

            if (word.ToLower().Equals(reversedWord.ToLower())) // if string entered is Upper case is making it lower case
            {
                Console.WriteLine("The word entered is palindrome: ");
            }
            else
            {
                Console.WriteLine("Not a palindrom word");
            }
            Console.ReadKey();
        }
    }
}
