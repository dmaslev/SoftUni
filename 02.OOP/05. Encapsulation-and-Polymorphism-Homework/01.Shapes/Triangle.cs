using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Triangle : BasicShape
    {
        private double c;
        public Triangle(double a, double b, double c)
            : base (a, b)
        {
            this.C = c;
        }

        protected double C { get; set; }

        public override double CalculateArea()
        {
            double p = (this.Width + this.Height + this.C) / 2;
            double area = Math.Sqrt(p * (p - this.Height) * (p - this.Width) * (p - this.C));


            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.Width + this.Height + this.C;

            return perimeter;
        }
    }
}
