//// Write a program that replaces all occurrences of the substring "start"
//// with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

namespace _07RaplacingSubstring
{
    using System.IO;

	public class RaplacingSubstring
	{
		public static void Main()
		{
			StreamReader searchingStart = new StreamReader(@"../../../Files/07. Text_with_substring_START.txt");
			StreamWriter replace = new StreamWriter(@"../../../Files/TASK07_Text_with_substring_FINISH.txt");

			using (searchingStart)
			{
				while (true)
				{
					string line = searchingStart.ReadLine();

					if (line == null)
					{
						break;
					}

					replace.WriteLine(line.Replace("start", "finish"));
					
				}

				replace.Flush();
			}
		}
	}
}
