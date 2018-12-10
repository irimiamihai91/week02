using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2

{
    class Course
    {
        public Course()
        {
            
        }

        private string name;
        private int year;
        
        private List<Student> listOfStudents;


       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
       
        
        public int Year
        {
            get { return year; }
            set { year = value;}
        }

        public List<Student> ListOfStudents { get; set; }
        
        public string Print()
        {
            return $"Course {Name} is teached in {year} year of studies. The students that are attending are : ";

        }
    }
  }

