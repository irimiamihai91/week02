using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Frog: Animal,Isound,IPrint
    {
        public Frog (string name, int age, string gender) : base(name,age,gender)
        {

        }

        public override string GetSound()
        {
            return ("Croak");
        }
      
    }
}
