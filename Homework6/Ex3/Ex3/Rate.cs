using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Rate
    {
       // private decimal Amount;
       // private string Curency;

        public Rate(decimal amount,string curency)
        {
            this.Amount = amount;
            this.Curency = curency;
        }

        public decimal Amount { get; set; }
        public string Curency { get; set; }

        public string Print()
        {
            return $"Rate is {Amount} {Curency}";
        }
    }
}
