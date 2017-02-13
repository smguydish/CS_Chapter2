using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int JobTime = 197;
            int hours = (JobTime / 60);
            int minutes = (JobTime % 60);
            Console.WriteLine(JobTime + " minutes is " + hours + " hours and " + minutes + " minutes.");
        }
    }
}
