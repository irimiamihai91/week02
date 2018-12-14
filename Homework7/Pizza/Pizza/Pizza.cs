
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        public Pizza(string name, PizzaBase pizzaBase, List<PizzaTopping> pizzaTooping1)
        {
            this.PizzaBase = pizzaBase;
            this.PizzaTopping1 = pizzaTooping1;
            this.Name = name;
        }

        public string Name { get; set; }

        public PizzaBase PizzaBase { get; set; }

        public List<PizzaTopping> PizzaTopping1 { get; set; }


        public void AddTopping(PizzaTopping topping)
        {
            PizzaTopping1.Add(topping);
        }

        public decimal TotalCost()
        {
            decimal costToping = 0;

            foreach (var topping in PizzaTopping1)
                costToping = costToping + topping.Cost;

            return PizzaBase.Cost + costToping;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}.");

            PizzaBase.Print();

            Console.WriteLine($"Toppings:");
            foreach (var topping in PizzaTopping1)
            {

                topping.Print();

            }

            Console.WriteLine($"Total pizza price is {TotalCost()}.");
            Console.WriteLine("----------------------------------------");
            
        }
    }
}
