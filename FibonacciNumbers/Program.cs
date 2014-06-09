using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces).");
            Console.WriteLine("Write n = ");
            int n = Int16.Parse(Console.ReadLine());
            string fibonacciSequence = "0 1";
            int n0 = 0;
            int n1 = 1;
            int sum;
            for (int i = 0; i < n-2; i++)
            {
                sum = n0 + n1;
                n0 = n1;
                n1 = sum;
                fibonacciSequence += " "+sum.ToString();
            }
            Console.WriteLine(fibonacciSequence);
        }
    }
}
