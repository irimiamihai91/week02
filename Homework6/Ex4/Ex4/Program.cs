using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var listBooks = new List<Books>();
            Books book1 = new Books("Bernard Russel", "In cautarea fericirii", 39.99);
            Books book2 = new Books("Thierry Dedieu", "In cautarea lui Mos Craciun", 29.9);
            Books book3 = new Books("Bob Dylan", "Cronica Vietii mele", 9.8);
            Books book4 = new Books("Lothar Seiwert", "Invata sa castigi timp! ", 9.9);
            Books book5 = new Books("Irina Binder", "Insomnii", 38.24);
            listBooks.Add(book1);
            listBooks.Add(book2);
            listBooks.Add(book3);
            listBooks.Add(book4);
            listBooks.Add(book5);

            int counter = 1;
            foreach(var elem in listBooks)
            {
                if (counter == 1)
                {
                    elem.Price = elem.Price + (elem.Price / 2);
                    elem.Title = elem.Title.ToUpper();
                    Console.WriteLine(elem.Print());
                }
                else if (counter == 5)
                {
                    elem.Price = elem.Price + (elem.Price / 2);
                    elem.Title = elem.Title.ToUpper();
                    
                    Console.WriteLine(elem.Print());
                }
                else
                {
                    Console.WriteLine(elem.Print());
                }
                counter++;
            }
            Console.ReadKey();


        }
    }
}
