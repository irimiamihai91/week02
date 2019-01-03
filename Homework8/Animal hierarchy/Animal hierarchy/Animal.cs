using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public abstract class Animal
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public abstract string GetSound();

        public  void Print()
        {
            Console.WriteLine($"Animal Name: {Name} , age: {Age}, gender : {Gender}");

        }
    }
}
