using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Shape
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[3];
            shapes[0] = new Circle(4);
            shapes[1] = new Rectangle(5, 5);
            shapes[2] = new Triangle(3, 4, 5);


            foreach (var shape in shapes)
            {
                Console.WriteLine("Area = {0}", shape.CalculateArea());
                Console.WriteLine("Perimeter = {0}", shape.CalculatePerimeter());
                Console.WriteLine(new string('_', 20));
            }
        }
    }
}
