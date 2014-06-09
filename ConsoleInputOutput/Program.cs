using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOf3Integers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads 3 integer numbers from the console and prints their sum.");
            Console.WriteLine();
            Console.WriteLine("Write the first integer number a = ");
            int a = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write the second integer number b = ");
            int b = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write the third integer number c = ");
            int c = Int16.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a+b+c);
        }
    }
}
