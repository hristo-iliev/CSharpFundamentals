//// Write a program that extracts from given HTML file its title (if available),
//// and its body text without the HTML tags.

namespace _25ExtractingTextFromHTML
{    
    using System;
    using System.IO;

    public class ExtractingTextFromHTML
    {
        public static void Main()
        {
            StreamReader html = new StreamReader(@"../../../html_file.html");
            using (html)
            {
                string line = string.Empty;
                while (true)
                {
                    line = html.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '<')
                        {
                            Console.Write(" ");
                            while (line[i] != '>')
                            {
                                i++;
                            }

                        }
                        else
                        {
                            Console.Write(line[i]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
