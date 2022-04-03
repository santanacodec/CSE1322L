using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10___Edgar_santana
{
    class Program
    {
        static void Main(string[] args)
        {
            int a
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

            if (!list.Contains(":"))
            {
                throw new InvalidTimeException("Invalid Format");
            }

            if (list.Count != 3)
            {
                throw new InvalidTimeException("Invalid Format");
            }
             
            if (hours < 0 || hours > 23 )
            {
                throw new InvalidTimeException("Hour not valid");
            }
            if (minutes < 0 || minutes > 59)
            {
                throw new InvalidTimeException("Minute not valid");
            }
            if (seconds < 0 || seconds > 59)
            {
                throw new InvalidTimeException("Seconds not valid");
            }

            return (hours * 60 * 60) + (minutes * 60) + seconds;

        }
    }

    class InvalidTimeException : Exception
    {
        public InvalidTimeException(string message) : base(message) { }
        
    }
}
