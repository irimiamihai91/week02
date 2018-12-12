using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Rate
    {
        public Rate(decimal amount,string curency)

        {
            this.Amount = amount;
            this.Curency = curency;
        }

        public decimal Amount{get;set;}

        public string Curency { get; set;}

        public void Print()
        {
            Console.WriteLine($"\t\t Price is {Amount} {Curency}.");
        }
    }
}
