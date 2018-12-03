using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Console.Write("Introduceti mesajul ce se doreste a fi verificat: ");
            string message = Console.ReadLine();

            Console.WriteLine("{0} : Este unic ? {1}" , message , isUnique(message) ? "Yes" : "No");
            Console.ReadKey();
        }

        public static bool isUnique(string message)
        {
            int[] count = new int[256];

            foreach(char c in message)
            {
                if (++count[c] > 1)
                    return false; // se gasete o litera care este duplicata
            }
            return true;
        }
    }
}
