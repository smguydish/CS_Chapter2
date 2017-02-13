using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of eggs for chick 1: ");
            int chick1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of eggs for chick 2: ");
            int chick2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of eggs for chick 3: ");
            int chick3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of eggs for chick 4: ");
            int chick4 = Convert.ToInt32(Console.ReadLine());

            int total = (chick1 + chick2 + chick3 + chick4);
            int dozen = (total / 12);
            int remainder = (total % 12);
            Console.WriteLine("A total of " + total + " eggs is " + dozen + " dozen and " + remainder + " eggs ");
        }
    }
}
