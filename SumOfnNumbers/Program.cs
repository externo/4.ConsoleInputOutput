using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfnNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that enters a number n and after that enters more n numbers and calculates and prints their sum.");
            Console.WriteLine("Write n = ");
            int n = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers.", n);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum of entered {0} numbers is {1}.", n, sum);
        }
    }
}
