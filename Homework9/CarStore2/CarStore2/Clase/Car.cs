using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    class Car : ICar
    {
        public Car(string model, int year, double price, Producer producer)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Producer = producer;

        }


        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public IProducer Producer { get; set; }
        
        public void Print()
        {
        
        Console.WriteLine($" : Producer: {this.Producer.Name}, Model {this.Model}, year {this.Year}, Price : {this.Price} EUR");
        
        }
    }
}
