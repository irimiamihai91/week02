using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class MasterClass
    {
        public void Check (){

        Author author1 = new Author("Mihai Irimia", "mihai.irimia@gmail.com");
        Author author2 = new Author("Bogdan Popoi", "bogdan.popoi@gmail.com");
        Author author3 = new Author("Mihai Irimia", "mihai@gamil.com");

        var authorList = new List<Author>();
            authorList.Add(author1);
            authorList.Add(author2);
            authorList.Add(author3);

            var bookList = new List<Book>();

            Book book1 = new Book("In cautarea fericirii",30,"Drama",authorList);
            bookList.Add(book1);

            Author author4 = new Author("Bucatariu", "alex@gmail.com");

            Book book2 = new Book(" Testamentul lui Abraham ", 25, "SF", authorList);
            
            book2.AddAuthor(author4);
            bookList.Add(book2);

            Library library1 = new Library("Biblioteca",bookList);
            library1.AddBooks(book1);
            library1.AddBooks(book2);


            //library1.Print();
            //author1.Print();
            book1.Print();










            //foreach(var author in authorList)
            //    {
            //        Console.WriteLine($"\tAuthor {author.Name} has the folowing email {author.Email}");
            //    }

            //Book book1 = new Book("In cautarea fericirii",Convert.ToDecimal( 20.90), "Drama", authorList);

            //var bookList = new List<Book>();

            //book1.AddAuthor(author1);
            //book1.AddAuthor(author2);
            //book1.AddAuthor(author3);

            //bookList.Add(book1);

            ////book1.Print();

            //foreach(var book in bookList)
            //{
            //    Console.WriteLine($"\tBook {book.Name} has the folowing email {book.Price} {book.Genre} {authorList}");
            //}
        }
    }
}
