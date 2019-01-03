using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public virtual double CalculateSurface()
        {
            return this.Width * this.Height;
        }

        public virtual void Print() 
        {
            Console.WriteLine($"{this.GetShapeType()} surface is {this.CalculateSurface()} ");
        }

        public abstract string GetShapeType();
    }
}
