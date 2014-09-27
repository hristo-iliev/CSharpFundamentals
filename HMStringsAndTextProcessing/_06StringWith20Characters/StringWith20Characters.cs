//// Write a program that reads from the console a string of maximum 20 characters. 
//// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//// Print the result string into the console.

using System;

namespace _06StringWith20Characters
{ 
    public class StringWith20Characters
    {
        public static void Main()
        {
            string input = "peshko pianoto";

            input = input.PadRight(20, '*');

            Console.WriteLine(input);
        }
    }
}
