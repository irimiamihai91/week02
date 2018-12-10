using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2

{
    class Student
    {
        public Student()
        {

        }
        private string name;
        private string faculty;
        private int year;

        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value;}
        }
        public int Year
        {
            get { return year; }
            set { year = value;}
        }
        public string Print ()
        {
            return $"The student {Name} is in {Year} year at {Faculty}";
        }

    }
}
