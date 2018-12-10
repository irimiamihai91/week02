using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2

{
    class Course
    {
        public Course(Professor prof1)
        {

            Professor = prof1;
        }

        private string name;
        private int year;
        
        public List<Student> listOfStudents;

        public  Professor Professor
        {
            get;
            
        }
 
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
            return $"Course {Name} is teached in {year} year of studies by {Professor.Name} . The students that are attending are : ";

        }
    }
  }

