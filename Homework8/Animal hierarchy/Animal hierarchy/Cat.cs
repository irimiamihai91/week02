using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Cat: Animal
    {
        public Cat (string name, int age, string gender) : base(name,age,gender)
        {

        }

        public override string GetSound()
        {
            return ("Miau");
        }
        
    }

}
