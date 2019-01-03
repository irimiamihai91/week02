using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Individual : Customer
    {
        public long CNP { get; private set; }

        public Individual(string name, long cnp)
        {
            this.Name = name;
            this.CNP = cnp;
            this.Type = CustomerType.Individual;
        }
        
        public override void Print()
        {
            Console.WriteLine($"Name: {this.Name} , CNP {this.CNP} is an {this.Type} person");
        }
    }
}
