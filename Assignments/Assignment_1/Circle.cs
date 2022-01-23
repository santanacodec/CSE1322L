using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
