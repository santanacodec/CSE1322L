using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Rectangle
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double perimeter()
        {
            return (2 * height) + (2 * width);
        }

        public double area()
        {
            return height * width;
        }
    }
}
