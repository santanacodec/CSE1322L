using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10___Edgar_santana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int format(string s)
        {
            int hours;
            int minutes;
            int seconds;
            List<string> list = new List<string>();
            
            list = s.Split(":", 3).ToList();

            hours = Convert.ToInt32(list[0]);
            minutes = Convert.ToInt32(list[1]);
            seconds = Convert.ToInt32(list[2]);
             

        }
    }
}
