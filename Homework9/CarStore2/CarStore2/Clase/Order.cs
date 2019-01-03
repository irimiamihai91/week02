using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    class Order : IOrder
    {
        public Order (int no, Car car, Customer customer)
        {

            this.No = no;
            this.Car = car;
            this.Customer = customer;
        }

        public Order() { }
        
        public DateTime DeliveryPeriod { get; set; }
    
        public int No { get; set; }

        public Customer Customer { get; set; }

        public Car  Car { get; set; }

        public void Print()
        {
            Console.WriteLine("Your order has been created");
            Console.WriteLine($"\t No : {this.No}:{this.DeliveryPeriod = DateTime.Now}");
            this.Customer.Print();
            this.Car.Print();
           
        }

    }
}
