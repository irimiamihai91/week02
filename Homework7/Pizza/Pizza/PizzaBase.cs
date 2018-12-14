using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaBase
    {
        public PizzaBase(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
           
           
        }
        public PizzaTopping PizzaTopping { get; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public List<PizzaTopping> Toppings { get; set; }

        public decimal GetPrice()
        {
            if (Name == "Italian")
            {
                return Cost * Convert.ToDecimal(1.5);
            }
            return Cost;
        }

        public decimal ToppingBaseCost ()
        {
            decimal result = GetPrice() + PizzaTopping.Cost;
            return result;
        }

        public void Print()
        {
            
            Console.WriteLine($"Pizza has the base: { Name} and cost: { GetPrice()}");
            //ghhmvbConsole.WriteLine($"After calculation the base costs : { ToppingBaseCost()}");
            // Console.WriteLine($"The Total is : {ToppingBaseCost()}");
        }
    }
}
