using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public Book(string name,decimal price, string genre, List<Author> authors)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Genre = genre;
        }

        public string Name{get;set;}

        public decimal Price { get; set; }

        public string Genre { get; set; }

        public List<Author> Authors { get; set; }


        public decimal GetPrice()
        {
            if (Genre == "Drama")
            {
                return this.Price * Convert.ToDecimal(0.9);
            }
            if (Genre == "SF")
            {
                return this.Price * Convert.ToDecimal(0.85);
            }
            return Price;
        }

        public void Print ()
        {
            Console.WriteLine($"Book {Name}:");
            Console.WriteLine($"\tPrice: {Price} , Gendre {Genre}");
            foreach (var author in Authors)
            {
                author.Print();
                    
            }
            Console.WriteLine($"\tAfter Discount:{GetPrice()}");
        }

        public void AddAuthor(Author author)
        {
            if (!Authors.Contains(author))
                Authors.Add(author);
        }

        //public void AddAuthor()
        //{
        //    Author a2 = new Author("Mihai Irimia", "mihai.irimia@gmail.com");

        //    foreach(var authorname in Authors)
        //    {
        //        if (a2 != authorname)
        //        {
        //            Authors.Add(a2);
        //        }

        //    }

    
        public void AddAuthor2(string name)
        {
            foreach (var author in Authors)
            {
                if (author.Name != name)
                {
                    Authors.Add(author);
                }
            }
        }
    }
}
