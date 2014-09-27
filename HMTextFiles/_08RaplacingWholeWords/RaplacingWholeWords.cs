//// Modify the solution of the previous problem to replace only whole words (not substrings).

namespace _08RaplacingWholeWords
{
    using System.IO;
    using System.Text.RegularExpressions;

    public class RaplacingWholeWords
    {
        public static void Main()
        {
            StreamReader searchingStart = new StreamReader(@"../../../Files/07. Text_with_substring_START.txt");
            StreamWriter replace = new StreamWriter(@"../../../Files/TASK08_Text_with_words_FINISH.txt");

            using (searchingStart)
            {
                while (true)
                {
                    string line = searchingStart.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    replace.WriteLine(Regex.Replace(line,@"\bstart\b", "finish"));
                    
                }

                ////http://stackoverflow.com/questions/6143642/way-to-have-string-replace-only-hit-whole-words
                ////string input = "test, and test but not testing.  But yes to test";
                ////string pattern = @"\btest\b";
                ////string replace = "text";
                ////string result = Regex.Replace(input, pattern, replace);
                replace.Flush();
            }
        }
    }
}
