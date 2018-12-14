using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    public class Rate
    {
        public Rate(decimal amount, string currency)
        {
            this.Amount = amount;
            if(currency == "USD" || currency == "RON")
            {
                this.Currency = currency;
            }
            else
            {
                Console.WriteLine("Invalid currency!");
            }
            
        }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public void Print()
        {
            Console.WriteLine($"\t\tPrice is : {Amount} {Currency}");
        }
    }
}
