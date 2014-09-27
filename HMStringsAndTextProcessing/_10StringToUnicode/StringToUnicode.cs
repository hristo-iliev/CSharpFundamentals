//// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

namespace _10StringToUnicode
{
    using System;

    public class StringToUnicode
    {
        public static void Main()
        {
            string input = "Hi!";

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u" + ((int)input[i]).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}
