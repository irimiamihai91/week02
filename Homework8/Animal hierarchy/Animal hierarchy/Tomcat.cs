﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "Male";
        }
        
    }
}
