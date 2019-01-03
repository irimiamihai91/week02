using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public override double CalculateSurface() // override method as it's calculated different
        {
            return (this.Width * this.Height)/2;
        }

        public override string GetShapeType()
        {
            return "Triangle";
        }

        //public override void Print() // same here
        //{
        //    Console.WriteLine($"{this.GetShapeType()} surface is {this.CalculateSurface()} ");
        //}
    }
}
