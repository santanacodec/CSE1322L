﻿using System;
using System.Collections.Generic;

namespace Assignment_3
{
    class Driver
    {
        List<Faculty> facultyObjects = new List<Faculty>();

        static void Main(string[] args)
        {
            
        } 

        public void addFaculty(List<Faculty> facultyObjects)
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
    }
}
