using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {

        public Square(double height)
        {
            this.Height = height;
            this.Width = height;
        }
        // calculate surface is the same as the one declared in base class. We will use that one since is virtual

        public override string GetShapeType()
        {
            return "Square";
        }

        //public override void Print()
        //{
        //    Console.WriteLine($"{this.GetShapeType()} surface is {this.CalculateSurface()} ");
        //}
    }
 }
 
