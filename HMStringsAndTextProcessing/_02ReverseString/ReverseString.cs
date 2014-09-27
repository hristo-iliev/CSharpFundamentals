//// Write a program that reads a string, reverses it and prints the result at the console.
//// Example: "sample"  "elpmas".

namespace _02ReverseString
{    
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string to reverse.");
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = input.Length-1; i >= 0; i--)
            {
                output.Append(input[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Reversed:");
            Console.WriteLine(output);
        }
    }
}
