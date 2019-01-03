using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    interface IOrder
    {
        int No { get; set; }

         DateTime DeliveryPeriod { get; set; }

         Customer Customer { get; set; }

         Car Car { get; set; }

         void Print();
       

    }
}
