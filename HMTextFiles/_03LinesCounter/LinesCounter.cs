//// Write a program that reads a text file and inserts line numbers in front of each of its lines.
//// The result should be written to another text file.


namespace _03LinesCounter
{
    using System.IO;

    public class LinesCounter
    {
        public static void Main()
        {
            StreamWriter txtWithLines = new StreamWriter(@"../../../Files/Task03_LineCounter.txt");
            StreamReader specialOffer = new StreamReader(@"../../../Files/03. Flight_To_Amsterdam.txt");

            using (specialOffer)
            {
                string line = string.Empty;
                int lineCounter = 1;

                while (true)
                {
                    line = specialOffer.ReadLine();

                    if (line == null)
                    {
                        break;
                    }
                    
                    txtWithLines.WriteLine("Line {0}:  {1}", lineCounter, line);

                    lineCounter++;
                }

                txtWithLines.Flush();
            }
        }
    }
}
