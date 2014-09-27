//// Write a program that reads a text file and prints on the console its odd lines.

namespace _01OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            StreamReader read = new StreamReader(@"..\..\..\Files\01. 10_Things_God_Can't_Do.txt");
            using (read)
            {                
                bool oddLine = true;

                string line = "";
                while (line != null)
                {
                    line = read.ReadLine();

                    if (oddLine)
                    {
                        Console.WriteLine(line);
                        oddLine = false;
                    }
                    else
                    {
                        oddLine = true;
                    }
                }
            }
        }
    }
}
