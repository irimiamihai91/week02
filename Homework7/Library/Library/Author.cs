using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author
    {
        public Author(string name, string email )
        {
            this.Name = name;

            if (email.Contains("@"))
           {

                this.Email = email;
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }
        }

        public string Name { get; set; }

        public string Email { get; set; }


        public void Print()
        {
            Console.WriteLine($"\tAuthor {Name} has the email adress {Email}");
        }
    }
}