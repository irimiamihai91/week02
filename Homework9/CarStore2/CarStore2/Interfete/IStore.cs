using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    interface IStore
    {
        string Name { get; set; }

        string Adress { get; set; }

        void AddCar(Car car);

        void RemoveCar(Car car);

        void VisitStore(Customer customer);

        void CancelOrder(int orderNumber);

        Car FindCar(string modelName);

        void PrintOrder();

        Order OrderCar(Customer customer, string Model);


    }
}
