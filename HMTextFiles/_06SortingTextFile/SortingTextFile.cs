//// Write a program that reads a text file containing a list of strings,
//// sorts them and saves them to another text file.

namespace _06SortingTextFile
{
    using System.Collections.Generic;
    using System.IO;

    public class SortingTextFile
    {
        
        static void Main()
        {
            StreamReader unsortedText = new StreamReader(@"../../../Files/06. UnsortedListOfStrings.txt");
            List<string> sorted = new List<string>();

            using (unsortedText)
            {
                
                while (true)
                {
                    string line = unsortedText.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    sorted.Add(line);
                }              
            }

            sorted.Sort();
            StreamWriter sortedText = new StreamWriter(@"../../../Files/Task06_SortedListOfStrings.txt");

            using (sortedText)
            {
                for (int i = 0; i < sorted.Count; i++)
                {
                    sortedText.WriteLine(sorted[i]);
                }

                sortedText.Flush();
            }
        }
    }
}
