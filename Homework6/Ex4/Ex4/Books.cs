using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Books
    {
        private string author;
        private string title;
        private double price;

        public Books(string Author, string Title, double Price)
        {
            this.author = Author;
            this.title = Title;
            this.price = Price;
        }
        public string Author
        { get { return author; }
          set { author = value;}
        }
        public string Title
        {
            get { return title; }
            set { title = value;}
        }
        public double Price
        {
            get { return price; }
            set { price = value;}
        }

        public string Print()
        {
            return $"The author of the book {Title} is {Author} and the price is {Price}";
        }


    }
}
