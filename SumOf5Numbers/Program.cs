using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that enters 5 numbers, calculates and prints their sum.");
            Console.WriteLine("Give a single line of numbers, separeted by a space.");
            string singleLine = Console.ReadLine();
            string[] numbersInLine = singleLine.Split(' ');
            double[] numbers = Array.ConvertAll(numbersInLine, double.Parse);
            double sum = numbers.Sum();
            Console.WriteLine("The sum of the single line numbers is: {0}", sum);
        }
    }
}
