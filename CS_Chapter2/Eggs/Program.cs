using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chick1 = 13;
            int chick2 = 59;
            int chick3 = 45;
            int chick4 = 10;
            int total = (chick1 + chick2 + chick3 + chick4);
            int dozen = (total / 12);
            int remainder = (total % 12);
            Console.WriteLine("A total of " + total + " eggs is " + dozen + " dozen and " + remainder + " eggs ");
        }
    }
}
