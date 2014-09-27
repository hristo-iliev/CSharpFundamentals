//// Write a program that deletes from a text file all words that start with the prefix "test".
//// Words contain only the symbols 0...9, a...z, A…Z, _.

namespace _11DeletingWordsWithPrefixTest
{	
    using System.IO;
    using System.Text.RegularExpressions;

	public class DeletingWordsWithPrefixTest
	{
		public static void Main()
		{
			StreamReader text = new StreamReader(@"../../../Files/11. Delete_Prefix_TEST.txt");
			StreamWriter testDel = new StreamWriter(@"../../../Files/TASK11_Delete_Prefix_TEST.txt");

			using(text)
			{
				string line = "";

				while (true)
				{
					line = text.ReadLine();

					if (line == null)
					{
						break;
					}

                    testDel.WriteLine(Regex.Replace(line, @"\btest\w*\b|\bTest\w*\b|\bTEST\w*\b", ""));
                    testDel.Flush();	
				}
			}
		}
	}
}
