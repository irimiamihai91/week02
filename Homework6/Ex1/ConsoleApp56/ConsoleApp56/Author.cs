using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1

    class Author
    {
        
            private string Name;
            private string Email;
            private string Country;

            public Author(string Name, string Email, string Country)
            {
                this.Email = Email;
                this.Name = Name;
                this.Country = Country;
            }

            public string Print()
            {
                return $"The Author {Name} from {Country} has the email adress {Email}";
            }
        }
}
