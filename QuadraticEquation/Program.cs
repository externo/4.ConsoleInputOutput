using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).");
            Console.WriteLine("Write a = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Write b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            float c = float.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - a * c;
            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
            else if (d == 0)
            {
                Console.WriteLine("The equation has only one root: x = {0}", b / 2);
            }
            else
            {
                double x1 = b / 2 + Math.Sqrt(d);
                double x2 = b / 2 - Math.Sqrt(d);
                Console.WriteLine("The equation has two real roots: x1 = {0} and x2 = {1}.",x1, x2);
            }

        }
    }
}
