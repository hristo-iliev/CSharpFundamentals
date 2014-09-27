//// Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace _09DeleteOddLines
{    
    using System.IO;

    public class deleteOddLines
    {
        public static void Main()
        {
            StreamReader someText = new StreamReader(@"../../../Files/09. Text_To_Delete_The_Odd_Lines.txt");
            string text = "";

            using (someText)
            {
                int lineCounter = 1;
                string line = "";              
                                
                while (true)
                {
                    line = someText.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (lineCounter % 2 == 0)
                    {
                        text += line + "\r\n";
                    }
                    
                    lineCounter++;
                }
            }

            StreamWriter withDeletedOddLines = new StreamWriter(@"../../../Files/09. Text_To_Delete_The_Odd_Lines.txt", true);

            using (withDeletedOddLines)
            {                
                withDeletedOddLines.WriteLine();
                withDeletedOddLines.WriteLine("TEXT WITH DELETED ODD LINES:");
                withDeletedOddLines.WriteLine();                
                withDeletedOddLines.WriteLine(text);                
            }
        }
    }
}
