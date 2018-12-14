using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaTopping
    {
        public PizzaTopping(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name { get; set; }

        public decimal Cost { get; set; }

        public void Print()
        {
            //Console.WriteLine($"Toppings:");

            if (Name == "Meat")
            {
                
                Console.WriteLine($"\t{Name.ToUpper()} and the cost is {Cost} RON");
            }
            else
            {
                
                Console.WriteLine($"\t{Name} and the cost is {Cost} RON");
            }
            
        }
    }
}
