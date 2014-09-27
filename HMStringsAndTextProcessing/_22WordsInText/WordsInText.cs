//// Write a program that reads a string from the console and lists all different
//// words in the string along with information how many times each word is found.

namespace _22WordsInText
{
    using System;
    using System.Collections.Generic;

    public class WordsInText
    {
        public static List<string> answer = new List<string>();

        static void CountingWords(string[] arr)
        {
            List<string> currentWords = new List<string>();

            foreach (var word in arr)
            {
                currentWords.Add(word);
            }

           

            while (currentWords.Count != 0)
            {
                int counter = 0;
                string currentWord = currentWords[0];

                for (int i = 0; i < currentWords.Count; i++)
                {
                    if (currentWords[i] == currentWord)
                    {
                        counter++;
                        currentWords.Remove(currentWords[i]);
                        i--;
                    }
                }

                answer.Add(currentWord + " -> " + counter.ToString());
            }
        }

        static void Print()
        {
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
        static void Main()
        {
            string text =
@"A-well-a, everybody's heard about the bird
Bird, bird, bird, b-bird's the word
A-well-a, bird, bird, bird, the bird is the word
A-well-a, bird, bird, bird, well, the bird is the word
A-well-a, bird, bird, bird, b-bird's the word
A-well-a, bird, bird, bird, well, the bird is the word
A-well-a, bird, bird, b-bird's the word
A-well-a, bird, bird, bird, b-bird's the word
A-well-a, bird, bird, bird, well, the bird is the word
A-well-a, bird, bird, b-bird's the word
A-well-a, don't you know about the bird
Well, everybody knows that the bird is the word
A-well-a, bird, bird, b-bird's the word
A-well-a";

            text = text.ToLower();
            
            text = text.Replace(",", String.Empty);
            char[] charSeparators = new char[] { ' ', '\n', '\r' };
            string[] words = text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            CountingWords(words);
            Print();
        }
    }
}
