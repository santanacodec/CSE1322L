using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Faculty : Employee
    {
        private double weeklySalary;
        private double weeklyStipend;
        private double weeklyPay;

        public Faculty(string name, double weeklySalary, double weeklyStipend) : base(name)
        {
            this.weeklySalary = weeklySalary;
            this.weeklyStipend = weeklyStipend;
        }

        public double getWeeklySalary()
        {
            return weeklySalary;
        }

        public double getWeeklyStipend()
        {
            return weeklyStipend;
        }

        public double getWeeklyPay()
        {
            return weeklyPay;
        }

        public void setWeeklySalary(double weeklySalary)
        {
            this.weeklySalary = weeklySalary;
        }

        public void setWeeklyStipend(double weeklyStipend)
        {
            this.weeklyStipend = weeklyStipend;
        }

        public void setWeeklyPay(double weeklyPay)
        {
            this.weeklyPay = weeklyPay;
        }

        public void calculateWeeklyPay()
        {
            weeklyPay = weeklySalary + weeklyStipend;
        }

        public override string ToString()
        {
            return base.ToString() + "\nWeekly Salary: " + weeklySalary +
                "\nWeekly Stipend: " + weeklyStipend + "\nWeekly Pay: " + weeklyPay;
        }
    }
}
