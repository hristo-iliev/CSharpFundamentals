//// Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace _03Today
{
    using System;

    public class Today
    {      
        public static void Main()
        {
            DateTime time = DateTime.Now;              
            string format = "dddddddd";

            Console.WriteLine("Today is {0}!", time.ToString(format));            
        }
    }
}
