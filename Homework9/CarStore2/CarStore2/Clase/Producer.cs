using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore2
{
    class Producer : IProducer
    {
        private string adress;

        public Producer(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public string Adress { get { return adress; } set {adress = value; } }
    }
}
