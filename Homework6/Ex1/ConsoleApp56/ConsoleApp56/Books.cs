using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1

{
    class Books
    {
        private string Name;
        private string Author;
        private int Year;
        private double Price;

        public Books(string Name, string Author, int Year, double Price)
        {
            this.Name = Name;
            this.Author = Author;
            this.Year = Year;
            this.Price = Price;
        }

        public string Print()
        {

            return $"The book {Name} has been written by {Author} in {Year} and it costs {Price}";
        }
    }
}
