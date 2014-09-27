//// Write a program that reads a list of words, separated by spaces
//// and prints the list in an alphabetical order.

namespace _24ListOfWordsAlphabetical
{
    using System;

    public class ListOfWordsAlphabetical
    {
        public static void Main()
        {
            string inputWords = "prase magare Kotio Kenka Penka Zlatka Zlatka Cherna Zlatka Losha Pile Puicho neggy";

            string[] words = inputWords.Split(' ');

            Array.Sort(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
