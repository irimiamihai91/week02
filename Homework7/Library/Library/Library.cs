using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        public Library(string name , List<Book> books)
        {
            this.Name = name;
            this.Books = books;

        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public void AddBooks(Book book)
        {
            if (!Books.Contains(book))
                Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if (Books.Contains(book))
                Books.Remove(book);
        }

        public void Print()
        {
            Console.WriteLine($"Library : {Name}");
            
            foreach (var book in Books)
            {
                book.Print();
            }
        }
    }
}
