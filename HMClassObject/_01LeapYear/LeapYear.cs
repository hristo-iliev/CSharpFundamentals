//// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace _01LeapYear
{
    using System;    

    public class LeapYear
    {
        public static void Main()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool leap = DateTime.IsLeapYear(year);

            if (leap)
            {
                Console.WriteLine("The year is leap!");
            }
            else
            {
                Console.WriteLine("The year isn't leap!");
            }
        }
    }
}
