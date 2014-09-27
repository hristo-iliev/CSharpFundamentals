//// Write a program that concatenates two text files into another text file.

namespace _02ConcatTwoTextFilesIntoAnother
{
    using System.IO;

    public class ConcatTwoTextFilesIntoAnother
    {
        public static void Main()
        {
            StreamWriter concat = new StreamWriter(@"../../../Files/Concatenated_File_From_Task02.txt");
            StreamReader bgpostsFirstPrgph = new StreamReader(@"../../../Files/02. BG_Posts.txt");

            using (bgpostsFirstPrgph)
            {
                do
                {
                    concat.WriteLine(bgpostsFirstPrgph.ReadLine());
                }
                while (!bgpostsFirstPrgph.EndOfStream);
                {
                    concat.WriteLine(bgpostsFirstPrgph.ReadLine());
                }
                concat.Flush();
            }

            StreamReader bgpostsSecondPrgph = new StreamReader(@"../../../Files/02. BG_Posts2.txt");
            using (bgpostsSecondPrgph)
            {
                do
                {
                    concat.WriteLine(bgpostsSecondPrgph.ReadLine());
                }
                while (!bgpostsSecondPrgph.EndOfStream);
                {
                    concat.WriteLine(bgpostsSecondPrgph.ReadLine());
                }
                concat.Flush();
            }
        }
    }
}
