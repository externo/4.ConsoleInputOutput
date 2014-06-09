using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersDividableByNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.");
            Console.WriteLine("Write the first positive integer number: ");
            int firstNumber = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write the second positive integer number: ");
            int secondNumber = Int16.Parse(Console.ReadLine());
            int p = 0;
            string comments = "";
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    comments += i.ToString() + ", ";
                }
            }
            comments = comments.Remove(comments.Length - 2);
            if (p == 0)
            {
                Console.WriteLine("There is no number between {0} and {1} that the reminder of the division by 5 is 0.",
                    firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("The numbers that the reminder of the division by 5 is 0 are: {0}. Their count is {1}.",
                    comments, p); 
            }
        }
    }
}
