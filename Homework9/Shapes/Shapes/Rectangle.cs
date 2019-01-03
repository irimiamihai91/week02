using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public override string GetShapeType()
        {
            return "Rectangle";
        }

        /// Calculate Surface . since method is the same with the one declared in base class we will use that one
        
        //public override void Print() // override as we wasnt to be printed different
        //{
        //    Console.WriteLine($"{this.GetShapeType()} surface is {this.CalculateSurface()} ");
        //}

        
    }
}
