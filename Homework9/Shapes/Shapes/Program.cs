using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] array = new Shape[4];

            Shape rectangle = new Rectangle();
            rectangle.Width = 3;
            rectangle.Height = 3;

            Shape triangle = new Triangle
            {
                Width = 4,
                Height = 4
            };

            Shape square = new Square(5);
            Shape square1 = new Square(6);
            
           
            array[0] = rectangle;
            array[1] = triangle;
            array[2] = square;
            array[3] = square1;

            foreach(var elem in array)
            {
                elem.Print();
            }

            Console.ReadLine();
        }
    }
}
