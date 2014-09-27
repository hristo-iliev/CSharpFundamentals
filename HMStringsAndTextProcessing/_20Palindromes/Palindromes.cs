//// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20Palindromes
{
    using System;
    using System.Collections.Generic;

    public class Palindromes
    {
        private static List<string> palindromes = new List<string>();

        public static void CheckIfPalindrome(string word)
        {
            int firstIndex = 0;
            int secondIndex = word.Length -1;
            bool isPalindrome = true; ;
            
            while (firstIndex < secondIndex)
            {
                if (word[firstIndex] != word[secondIndex])
                {
                    isPalindrome = false;
                    break;
                }

                firstIndex++;
                secondIndex--;
            }

            if (isPalindrome)
            {
                if (word.Length > 1)
                {
                    palindromes.Add(word);
                }                
            }
        }

        public static void Print()
        {
            for (int i = 0; i < palindromes.Count; i++)
            {
                Console.WriteLine(palindromes[i]);
            }
        }

        public static void Main()
        {
            string text = @"Baba mi e losha. Tq slusha ABBA i qde bob sys sos ot raci. 
                            Drug dovod, che e luda, e sushto, che hapva exe i rar failove.";

            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim(new char[] { '.', ',',':','?','!' }); 

                CheckIfPalindrome(words[i]);
            }

            Print();
        }
    }
}
