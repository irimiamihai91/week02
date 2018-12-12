using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Room

    {
        public Room(string name, Rate Rate,int adults,int children)
        {
            this.Name = name;
            this.Rate = Rate;
            this.Adults = adults;
            this.Children = children;
        }
        public string Name { get; set; }

        public Rate Rate { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public decimal GetPrice(int numberOfDays)
        {
            
            return this.Rate.Amount * numberOfDays;
        }

        public decimal GetPriceChildren()
        {
            if (this.Children > 0)
            {
                return Rate.Amount * Convert.ToDecimal(1.3);
            }
            return Rate.Amount;
        }

        public void Print()
        {
            Console.WriteLine($"\tRoom name is {Name}:");
            Console.WriteLine($"\t\t Adults : {Adults} Children: {Children} ");
            this.Rate.Print();
            Console.WriteLine($"\t After calculation: {GetPriceChildren}");
        }

    }
}
