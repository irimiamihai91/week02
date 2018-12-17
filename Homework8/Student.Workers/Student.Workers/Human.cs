using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Workers
{
    public abstract class Human
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"First Name : {FirstName}, Last Name : {LastName}");
    }
    }

    
}
