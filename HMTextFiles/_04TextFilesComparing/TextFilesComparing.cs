//// Write a program that compares two text files line by line and prints the number of lines
//// that are the same and the number of lines that are different. Assume the files have equal number of lines.

namespace _04TextFilesComparing
{
    using System;
    using System.Text;
    using System.IO;

    public class TextFilesComparing
    {
        public static void Main()
        {
            StreamReader firstText = new StreamReader(@"../../../Files/04. SomeText_1.txt");
            StreamReader secondText = new StreamReader(@"../../../Files/04. SomeText_2.txt");

            string firstTxtLine = "";
            string secondTxtLine = "";

            StringBuilder equalLines = new StringBuilder();
            StringBuilder differentLines = new StringBuilder();

            int lineCounter = 1;
            try
            {                
                while (firstTxtLine != null)
                {
                    firstTxtLine = firstText.ReadLine();
                    secondTxtLine = secondText.ReadLine();

                    if (firstTxtLine == secondTxtLine && firstTxtLine != null)
                    {
                        equalLines.Append(lineCounter.ToString() + " ");
                    }
                    else if (firstTxtLine != secondTxtLine)
                    {
                        differentLines.Append(lineCounter.ToString() + " ");
                    }

                    lineCounter++;
                }

                if (firstTxtLine != null || secondTxtLine != null)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("Equal lines:");
                Console.WriteLine(equalLines);
                Console.WriteLine();
                Console.WriteLine("Different lines:");
                Console.WriteLine(differentLines);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine("The given texts are with different length!", ex.StackTrace);               
            }
            finally
            {
                firstText.Close();
                secondText.Close();
            }            
        }
    }
}
