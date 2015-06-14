using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) :
            base (width, height)
        {

        }

        public override double CalculateArea()
        {
            double area = this.Height * this.Width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * this.Height + 2 * this.Width;
            return perimeter;
        }
    }
}
