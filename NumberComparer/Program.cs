using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that gets two numbers from the console and prints the greater of them. ");
            Console.WriteLine("Write the first number: ");
            float firstNumber= float.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("The greater number of {0} and {1} is {2}.",
                firstNumber, secondNumber, Math.Max(firstNumber, secondNumber));
        }
    }
}
