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

            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Rectangle rectangle = new Rectangle(i, j);
                    Console.WriteLine("The Area of a rectanlge " + i + " " +
                        j + " is " + rectangle.area() + " and its perimeter is " +
                        rectangle.perimeter());
                }
            }
        }
    }
}
