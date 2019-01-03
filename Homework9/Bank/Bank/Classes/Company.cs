using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Company : Customer
    {
        public string CUI { get; set; }

        public Company(string name, string cui)
        {
            this.Name = name;
            this.CUI = cui;
            this.Type = CustomerType.Company;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {this.Name}, CUI {this.CUI}, is a {this.Type} ");
        }
    }
}
