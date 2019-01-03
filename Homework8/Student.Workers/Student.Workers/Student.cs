using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Workers
{
    class Student:Human
    {
        public Student()
        {

        }
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;

        }
        public double Grade { get; set; }

        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} Grade: {this.Grade}" );
            //Console.WriteLine("--------------------------------------");
        }
    }
}
