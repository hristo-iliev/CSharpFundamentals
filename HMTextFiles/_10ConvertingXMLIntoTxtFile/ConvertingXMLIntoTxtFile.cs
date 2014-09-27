//// Write a program that extracts from given XML file all the text without the tags.

namespace _10ConvertingXMLIntoTxtFile
{
    using System.Text;
    using System.IO;

    public class ConvertingXMLIntoTxtFile
    {
        public static void Main()
        {
            StreamReader xml = new StreamReader(@"../../../Files/10. XML_File.xml");
            StreamWriter txt = new StreamWriter(@"../../../Files/TASK10_XML_File_into_txt.txt");

            using (xml)
            {
                string line = "";

                while (true)
                {
                    line = xml.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    StringBuilder content = new StringBuilder();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '<')
                        {
                            while (line[i] != '>')
                            {
                                i++;
                            }
                            
                        }
                        else
                        {
                            content.Append(line[i]);
                        }
                    }
                    txt.WriteLine(content);
                }
            }
        }
    }
}
