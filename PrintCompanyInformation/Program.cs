using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCompanyInformation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads the information about a company and its manager and prints it back on the console. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.");
            Console.WriteLine();

            //name, address, phone number, fax number, web site and manager
            Console.WriteLine("Write the information about the company.");
            Console.WriteLine("Write the company\'s name: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("Write the company\'s address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Write the company\'s phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Write the company\'s fax number: ");
            long faxNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Write the company\'s website: ");
            string webSite = Console.ReadLine();           

            //first name, last name, age and a phone number
            Console.WriteLine();
            Console.WriteLine("Write the information about the manager");
            Console.WriteLine("Write the manager\'s first name: ");
            string mFirstName = Console.ReadLine();
            Console.WriteLine("Write the manager\'s last name: ");
            string mLastName = Console.ReadLine();
            string manager = mFirstName + " " + mLastName;
            Console.WriteLine("Write the manager\'s age: ");
            int mAge = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Write the manager\'s phone number: ");
            string mPhoneNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("The company {0} is on address {1}. Their phone and fax numbers are: {2}, {3}. Have website {4} and manager {5}.",
                companyName, address, phoneNumber, faxNumber, webSite, manager);
            Console.WriteLine("{0} is {1} years old. His phone number is {2}.", manager, mAge, mPhoneNumber);
        }
    }
}
