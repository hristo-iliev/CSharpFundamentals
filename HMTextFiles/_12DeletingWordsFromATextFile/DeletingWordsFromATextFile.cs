//// Write a program that removes from a text file all words listed in given another text file.
//// Handle all possible exceptions in your methods.

namespace _12DeletingWordsFromATextFile
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.IO;

    public class DeletingWordsFromATextFile
    {
        public static string ConvertoToList(StreamReader someWords)
        {
            List<string> words = new List<string>();

            string line = "";

            while (true)
            {
                line = someWords.ReadLine();

                if (line == null)
                {
                    break;
                }

                words.Add(line);

            }

            string output = string.Join("|", words);             
            return output;
        }

        public static void Main()
        {
            StreamReader listWithWords = new StreamReader(@"../../../Files/12. List_With_Words.txt");
            StreamReader txt = new StreamReader(@"../../../Files/12. Text.txt");
            StreamWriter txtWithDeletedWords = new StreamWriter(@"../../../Files/TASK12_List_With_Words.txt");

            string words = ConvertoToList(listWithWords);
            using (txt)
            {
                string line = string.Empty;

                while (true)
                {
                    line = txt.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    txtWithDeletedWords.WriteLine(Regex.Replace(line, @"\b(" + words + @")\b", ""));
                }
            }
        }
    }
}
