using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Driver
    {       
        static void Main(string[] args)
        {
            List<Faculty> facultyObjects = new List<Faculty>();

            int choice;

            while(true)
            {
                Console.WriteLine("Please choose from the following menu");

                Console.WriteLine("1- Add Faculty");
                Console.WriteLine("2- Delete Faculty");
                Console.WriteLine("3- Calculate Faculty Pay");
                Console.WriteLine("4- Print Faculty");
                Console.WriteLine("5- Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        addFaculty(facultyObjects);
                        continue;
                    case 2:
                        removeFaculty(facultyObjects);
                        continue;
                    case 3:
                        calculateFacultyPay(facultyObjects);
                        continue;
                    case 4:
                        printFaculty(facultyObjects);
                        continue;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please choose from numbers 1 - 5 from the menue");
                        break;
                }
            }
        } 

        public static void addFaculty(List<Faculty> facultyObjects)
        {
            Console.WriteLine("Please enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your weekly salary: ");
            double weeklySalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your weekly stipend: ");
            double weeklyStipend = Convert.ToDouble(Console.ReadLine());

            Faculty faculty = new Faculty(name, weeklySalary, weeklyStipend);

            facultyObjects.Add(faculty);
        }

        public static void removeFaculty(List<Faculty> facultyObjects)
        {
            Console.WriteLine("Please enter a name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < facultyObjects.Count; i++)
            {
                if(name == facultyObjects[i].getName())
                {
                    facultyObjects.RemoveAt(i);
                }
            }
        }

        public static void calculateFacultyPay(List<Faculty> facultyObjects)
        {
            for(int i = 0; i < facultyObjects.Count; i++)
            {
                facultyObjects[i].calculateWeeklyPay();
            }
        }

        public static void printFaculty(List<Faculty> facultyObjects)
        {
            for(int i = 0; i < facultyObjects.Count; i++)
            {
                Console.WriteLine(facultyObjects[i]);
            }
        }
    }
}
