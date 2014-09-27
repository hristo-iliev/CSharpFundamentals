//// Write a program that reads a string from the console and replaces all series of consecutive
//// identical letters with a single one. 
//// Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

namespace _23ReplacingIdenticalLetters
{
    using System;
    using System.Text;

    public class ReplacingIdenticalLetters
    {
        public static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder currentText = new StringBuilder();
            currentText.Append(text);

            char letter = currentText[0];

            for (int i = 1; i < currentText.Length; i++)
            {
                if (currentText[i] == letter)
                {
                    currentText.Remove(i, 1);
                    i--;
                }
                else if (currentText[i] != letter)
                {
                    letter = currentText[i];
                }
            }

            Console.WriteLine(currentText);
        }
    }
}
