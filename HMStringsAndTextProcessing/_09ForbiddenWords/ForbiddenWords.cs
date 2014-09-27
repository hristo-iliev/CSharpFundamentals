//// We are given a string containing a list of forbidden words and a text containing some of these words.
//// Write a program that replaces the forbidden words with asterisks.

namespace _09ForbiddenWords
{
    using System;
    using System.Collections.Generic;

    public class ForbiddenWords
    {
        public static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            List<string> forbiddenWords = new List<string> { "Microsoft", "PHP", "CLR" };

                       

            for (int i = 0; i < forbiddenWords.Count; i++)
            {
                text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));

            }

            Console.WriteLine(text);
            
        }
    }
}
