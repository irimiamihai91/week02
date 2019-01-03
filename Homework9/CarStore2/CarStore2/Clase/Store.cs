using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{ 

    class Store : IStore
{
    private List<Car> _cars = new List<Car>();

    private List<Order> _orders = new List<Order>(); 
    
    private string adress;

    public Store(string name)
    {
      this.Name = name;
    }
    
    public string Name { get; set ; }

    public string Adress { get; set; }

    public void AddCar(Car car)
    {
         _cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        _cars.Remove(car);
    }

    public void CancelOrder(int orderNumber)
        {
           foreach(var order in _orders)
            {
                if (orderNumber == order.No)
                {
                    _orders.Remove(order);
                }
            }
        }

    public Order OrderCar(Customer customer, string Model)
        {
            var car = FindCar(Model);
            Random rnd = new Random();
            Order order = new Order()
            {

                Customer = customer,
                Car = car,
                No = rnd.Next(99),
                
                
            };


            _orders.Add(order);

            

            return order;
        }

        public void PrintOrder()
        {
            foreach (var orders in _orders)
            {
                orders.Print();
            }
        }

        public Car FindCar(string modelName)
        {
            foreach (var car in _cars)
                if (car.Model.ToLower() == modelName.ToLower())
                    return car;

            return null;
        }

       

    public void VisitStore(Customer customer)
    {
            Console.WriteLine($"{customer.Name} is visiting store : {Name}");
            Console.WriteLine($"Would you like to see a list with our models?");
            Console.Write($"Hint : Y/N                                                                                                              "  );
            string answer = Console.ReadLine();
            
            if (answer.ToLower() == "Y".ToLower())
            {
                foreach(var car in _cars)
                {

                    car.Print();
                    
                }

            }

            else
            {
                Console.WriteLine("OK, thank you for visiting our store :)"); 
            }

        }
       
    }
}
