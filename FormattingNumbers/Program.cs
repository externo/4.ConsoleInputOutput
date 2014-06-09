using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.");
            Console.WriteLine("Write a = ");
            int a = Int16.Parse(Console.ReadLine());
            string aHex = a.ToString("X");
            string aBinary = Convert.ToString(a, 2);
            Console.WriteLine("Write b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Write c = ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("The result is: |{0}|{1}|{2}|{3}|", aHex.PadRight(10), aBinary.PadLeft(10, '0'),
                b.ToString("0.00").PadLeft(10), c.ToString("0.000").PadRight(10));
        }
    }
}
