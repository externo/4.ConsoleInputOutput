using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CirclePerimeterArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.");
            Console.WriteLine("Write r = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of a circle with radius {0} is {1:0.00}. His area is {2:0.00}.", r, 2*r*Math.PI, Math.PI*Math.Pow(r,2));
        }
    }
}