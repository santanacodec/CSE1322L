using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public Triangle()
        {
            side1 = 3;
            side2 = 4;
            side3 = 5;
        }

        public double perimeter()
        {
            return side1 + side2 + side3;
        }

        public double area()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p*(p - side1) * (p - side2) * (p - side3));
        }

        public double height()
        {
            return (area() * 2) / side1;
        }

     
        public override string toString()
        {
            return "Triangle has sides " + side1 + ", " + side2 + ", " + side3 +
                ", and has an area of " + area() + " and a perimeter of " +
                perimeter();
        }
    }
}
