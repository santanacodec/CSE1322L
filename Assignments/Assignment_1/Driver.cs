using System;

namespace Assignment_1
{
    class Driver
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i < 11; i++)
            {
                Circle circle = new Circle(i);
                Console.WriteLine("Area of a circle with radius " + i + " is " +
                    circle.area() + " circumference is " + circle.circumference());

            }
        }
    }
}
