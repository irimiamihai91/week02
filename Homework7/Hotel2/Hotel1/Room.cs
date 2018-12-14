using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    public class Room
    {
        public Room(string name,Rate rate,int adults,int children)
        {
            this.Name = name;
            this.Rate = rate;
            this.Adults = adults;
            this.Children = children;
        }

        public string Name { get; set; }

        public Rate Rate { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public decimal GetPrice()
        {
            if (Children == 1)
            {
                return this.Rate.Amount * Convert.ToDecimal(1.3);
            }
            return this.Rate.Amount;
        }

        public void Print()

        {
            Console.WriteLine($"\tRoom name is {Name}:");
            Console.WriteLine($"\t\t Adults: {Adults}, Childrens:{Children}");
            this.Rate.Print();
            Console.WriteLine($"\t\t After Calculation {this.GetPrice()}");
        }
    }
}
