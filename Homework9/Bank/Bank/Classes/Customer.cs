using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Customer : ICustomer
    {
        public string Name { get; set; }

        public CustomerType Type {get;set;}

        public abstract void Print();
        
    }

    public enum CustomerType
    {
        Individual,
        Company
    };
}
