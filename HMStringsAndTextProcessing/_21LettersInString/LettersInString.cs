//// Write a program that reads a string from the console and prints all different letters
//// in the string along with information how many times each letter is found.

namespace _21LettersInString
{
    using System;
    using System.Collections.Generic;

    public class LettersInString
    {
        private static List<string> letters = new List<string>();

        public static void LettersCount(string input)
        {
            
            while (input != "")
            {
                int counter = 0;
                char letter = input[0];

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == letter)
                    {
                        counter++;
                    }
                }

                input = input.Replace(letter.ToString(), String.Empty);

                letters.Add(letter.ToString() + " -> " + counter.ToString());
            }                                                                

            
        }

        public static void Print()
        {
            for (int i = 0; i < letters.Count; i++)
            {
                Console.WriteLine(letters[i]);
            }
        }

        public static void Main()
        {
            string text = "lalalala I am your uncle Bob The Big Mama";

            string currentText = text.Replace(" ", String.Empty);
            currentText = currentText.ToLower();
            LettersCount(currentText);
            Print();
        }
    }
}
