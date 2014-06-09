using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers1toN
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.");
            Console.WriteLine("Write n = ");
            int n = Int16.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
