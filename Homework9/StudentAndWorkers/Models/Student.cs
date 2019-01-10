using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : Human
    {
        public int Grade { get; }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public void Print()
        {
            Console.WriteLine($"First Name : {this.FirstName}, Last Name : {this.LastName}, Grade {this.Grade} ");
        }

        public static bool operator < (Student s1, Student s2)
        {
            if (s1.Grade < s2.Grade)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator >(Student s1, Student s2)
        {
            if (s1.Grade > s2.Grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
