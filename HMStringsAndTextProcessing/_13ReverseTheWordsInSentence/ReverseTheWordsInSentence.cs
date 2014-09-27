//// Write a program that reverses the words in given sentence.
//// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

namespace _13ReverseTheWordsInSentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ReverseTheWordsInSentence
	{
        public static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";

            StringBuilder splitingWords = new StringBuilder(text);
            List<char> signs = new List<char> { ',', '.', '!', '?', ':' };
            List<string> signsStr = new List<string> { ",", ".", "!", "?", ":" };


            for (int i = 0; i < splitingWords.Length; i++)
            {
                if (signs.Contains(splitingWords[i]))
                {
                    splitingWords.Insert(i, ' ');
                    i++;
                }
            }

            string[] result = splitingWords.ToString().Split(' ');

            int fisrtIndex = 0;
            int secondIndex = result.Length - 1;

            while (fisrtIndex < secondIndex)
            {
                if (signsStr.Contains(result[fisrtIndex]))
                {
                    fisrtIndex++;
                }
                else if (signsStr.Contains(result[secondIndex]))
                {
                    secondIndex--;
                }
                else
                {
                    string current = result[fisrtIndex];
                    result[fisrtIndex] = result[secondIndex];
                    result[secondIndex] = current;
                    fisrtIndex++;
                    secondIndex--;
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i + 1 < result.Length && !signsStr.Contains(result[i + 1]))
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
	}
}
