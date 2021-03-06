﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Circle : IShape
    {
        private double radius;
        private const double pi = Math.PI;

        public Circle(double radius)
        {
            this.Radius = radius;   
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("radius", "Radius cannot be negative number");
                }

                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }
        public double CalculatePerimeter()
        {
            double perimeter = Math.PI * this.Radius * 2;
            return perimeter;
        }
    }
}
