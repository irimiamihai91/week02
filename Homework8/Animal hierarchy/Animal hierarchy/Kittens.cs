using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Kittens : Cat , Isound,IPrint
    {
        public Kittens(string name, int age, string gender) : base(name,age,gender)
        {
            this.Gender = "Female";
        }
     
    }
}
