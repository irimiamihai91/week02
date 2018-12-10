using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2

{
    class Professor
    {
        public Professor()
        {

        }
        private string name;
        private string faculty;
        private string specialization;

        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value;}
        }

        public string Print()
            
        {
            return $"The professor {Name} si teaching {Specialization} at {Faculty} faculty ";
        }
    }
}
