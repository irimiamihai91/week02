using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    interface ICar
    {
        string Model { get; set; }
        int Year { get; set; }
        double Price { get; set; }
        IProducer Producer { get; set; }
        void Print();
    }
}
