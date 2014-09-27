////2013-09-14_Evening

namespace _06MovingLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovingLetters
	{
		static List<char> lower = new List<char> 
		{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
		static List<char> upper = new List<char> 
		{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };

		static string Word(string[] arr)
		{
			List<string> newStr = new List<string>();

			for (int i = 0; i < arr.Length; i++)
			{
				var x = new StringBuilder();
				for (int j = arr[i].Length - 1; j >= 0; j--)
				{
					
					x.Append(arr[i][j]);
				}

				newStr.Add(x.ToString());
			}

			var result = new StringBuilder();

			int inx = 0;
			while (newStr.Count != 0)
			{
				for (int i = 0; i < newStr.Count; i++)
				{
					if (inx == newStr[i].Length)
					{
						newStr.Remove(newStr[i]);
						i--;
					}
					else
					{
						result.Append(newStr[i][inx]);
					}
					
				}

				inx++;
			}

			return result.ToString();
		}

		public static string AddInPosition(string word)
		{
			var result = new StringBuilder(word);           

			for (int i = 0; i < result.Length; i++)
			{
                int newInx = 0;
                char cur = result[i];

                result.Remove(i, 1);

                if (lower.Contains(cur))
                {
                    newInx = i + lower.IndexOf(cur) + 1;
                }
                else if (upper.Contains(cur))
                {
                    newInx = i + lower.IndexOf(cur) + 1;
                }

                if (newInx > result.Length)
                {
                    while (newInx > result.Length)
                    {
                        newInx -= result.Length;
                        newInx -= 1;
                    }
                }                

                if (newInx < result.Length)
                {
                    result.Insert(newInx, cur);
                }
                else if (newInx == result.Length)
                {
                    result.Append(cur);
                }                
			}

            return result.ToString();
		}

		public static void Main()
		{
			string input = Console.ReadLine();
            ////string input = "If you want to take your exam at Telerik Academy study hard and come well prepared";

			string[] arr = input.Split(' ');
            string word;
            if (arr.Length == 1)
            {
                StringBuilder x = new StringBuilder();

                for (int i = input.Length-1; i >= 0; i--)
                {
                    x.Append(input[i]);
                }

                word = x.ToString();
            }
            else
            {
                word = Word(arr);
            }

            Console.WriteLine(AddInPosition(word));
		}
	}
}
