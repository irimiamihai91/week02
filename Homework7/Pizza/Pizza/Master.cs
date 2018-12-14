using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Master
    {

       

        public void CreatePizza()
        {
           
            List<PizzaTopping> toppingsList = new List<PizzaTopping>();

            var topping1 = new PizzaTopping("Meat", 20);
            var topping2 = new PizzaTopping("Bufalo", 10);
            var topping3 = new PizzaTopping("Cheese", 5);
            var topping4 = new PizzaTopping("Vegetable", 10);
            

            var listToppings1 = new List<PizzaTopping>();
            listToppings1.Add(topping1);
            listToppings1.Add(topping2);

            var listToppings2 = new List<PizzaTopping>();
            listToppings2.Add(topping1);
            listToppings2.Add(topping3);

            var listToppings3 = new List<PizzaTopping>();
            listToppings3.Add(topping3);
            listToppings3.Add(topping4);


            var pizzaBase1 = new PizzaBase("Regular", 5);
            var pizzaBase2 = new PizzaBase("Italian", 10);
            var pizzaBase3 = new PizzaBase("Thick", 10);
            
            var pizza1 = new Pizza("Quatro-Stagione", pizzaBase1, listToppings1);
            var pizza2 = new Pizza("Con-Carne", pizzaBase3, listToppings2);
            var pizza3 = new Pizza("Veggie", pizzaBase2, listToppings3);

            pizza1.Print();
            pizza2.Print();
            pizza3.Print();





        }
    }
}
