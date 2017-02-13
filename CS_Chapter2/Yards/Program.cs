using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25;     
            int width = 42;
            int area = ((length * width)/ 9;
            double cost = (area * 1.50);
            Console.WriteLine("The cost of " + area + " yards, is " + cost );
        }
    }
}
