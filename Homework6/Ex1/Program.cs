using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1

{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Ion Creanga", "ion creanga@gmail.com", "Romania");
            var author_print = a1.Print();
            Books book1 = new Books("Amintiri din copilarie", "Ion Creanga", 1988, 39.99);
            var book_print = book1.Print();
            Console.WriteLine(author_print);
            Console.WriteLine(book_print);
            Console.ReadKey();
        }
    }
}
