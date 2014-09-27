//// A dictionary is stored as a sequence of text lines containing words and their explanations.
//// Write a program that enters a word and translates it by using the dictionary.

namespace _14Dictionary
{
    
    using System;
    using System.Collections.Generic;

    public class DictionaryWords
    {
        public static void Main()
        {
            string dict = @".NET – platform for applications from Microsoft
                            CLR – managed execution environment for .NET
                            namespace – hierarchical organization of classes";

            string[] splited = dict.Split('\n'); 

            Dictionary<string, string> dictWords = new Dictionary<string,string>();


            for (int i = 0; i < splited.Length; i++)
            {
                string[] words = splited[i].Split('–');


                words[0] = words[0].Trim(new char[] { ' ' });
                words[1] = words[1].Trim(new char[] { ' ' });

                dictWords.Add(words[0], words[1]);

            }

            Console.Write("Word = ");
            string searchWord = Console.ReadLine();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Exponation: " + dictWords[searchWord]);
                
            }
            catch (Exception)
            {
                Console.Error.WriteLine("The given word doesn't exist in the dictionary!");
                Console.WriteLine("Try again!");
                Console.ReadKey();
                Console.Clear();
                Main();
            }            
        }
    }
}
