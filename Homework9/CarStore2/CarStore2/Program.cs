using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store FordStore = CreateFordStore();
            Customer customer1 = new Customer("Alex");
            FordStore.VisitStore(customer1);

            Order orderforAlex = FordStore.OrderCar(customer1, "Focus");
            orderforAlex.Print();
           



            //Store SkodaStore = CreateSkodaStore();
            //SkodaStore.VisitStore(customer1);
            //Order orderforAlex2 = SkodaStore.OrderCar(customer1, "Octavia");

            Console.ReadKey();



        }

        private static Store CreateFordStore()
        {
            Producer Ford = new Producer("Ford");
            var car1 = new Car("Fusion", 2010, 14000, Ford);
            var car2 = new Car("Focus", 2013, 10000, Ford);
            var car3 = new Car("Kuga", 2015, 16000, Ford);
            var car4 = new Car("Focus", 2015, 15000, Ford);

            Store FordStore = new Store("Ford Store");
            FordStore.AddCar(car1);
            FordStore.AddCar(car2);
            FordStore.AddCar(car3);
            FordStore.AddCar(car4);
            

            return FordStore;
        }

        private static Store CreateSkodaStore()
        {
            Producer Skoda = new Producer("Skoda");
            var car1 = new Car("Octavia", 2010, 14000, Skoda);
            var car2 = new Car("Fabia", 2013, 10000, Skoda);
            var car3 = new Car("Superb", 2015, 16000, Skoda);
            var car4 = new Car("Octavia", 2014, 15000, Skoda);

            Store SkodaStore = new Store("Skoda Store");
            SkodaStore.AddCar(car1);
            SkodaStore.AddCar(car2);
            SkodaStore.AddCar(car3);
            SkodaStore.AddCar(car4);

            return SkodaStore;
        }
    }
}
