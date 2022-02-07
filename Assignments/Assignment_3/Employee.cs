using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Employee
    {
        private string name;
        private int employeeID;
        private static int numberOfEmployees = 0;

        public Employee()
        {
            name = "New Employee";
            employeeID = ++numberOfEmployees;
        }

        public Employee(string name)
        {
            this.name = name;
            employeeID = ++numberOfEmployees;
        }

        public string getName()
        {
            return name;
        }

        public int getEmployeeID()
        {
            return employeeID;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setEmployeeID(int employeeID)
        {
            this.employeeID = employeeID;
        }

        public static int getNumberOfEmployees()
        {
            return numberOfEmployees;
        }

        public static void decreaseNumberOfEmployees()
        {
            numberOfEmployees--;
        }
    }
}
