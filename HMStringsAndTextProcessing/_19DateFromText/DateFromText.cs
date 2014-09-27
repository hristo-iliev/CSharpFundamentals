//// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//// Display them in the standard date format for Canada.

namespace _19DateFromText
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class DateFromText
	{
        public static int HowManyDotts(string date)
		{
			int counter = 0;

			for (int i = 0; i < date.Length; i++)
			{
				if (date[i] == '.')
				{
					counter++;
				}
			}

			return counter;
		}

        public static void Main()
		{
			string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

			string[] words = text.Split(' ');

			List<string> dates = new List<string>();

			for (int i = 0; i < words.Length; i++)
			{
				int number;
				
				bool res = int.TryParse(words[i][0].ToString(), out number); 
				if (res)
				{
					dates.Add(words[i]);
				}
			}

			for (int i = 0; i < dates.Count; i++) 
			{
				dates[i] = dates[i].Trim(new char[] { '.' });
				if (HowManyDotts(dates[i]) == 2)
				{
					string[] checkYear = dates[i].Split('.');

					if (checkYear[2].Length != 4)
					{
						dates.Remove(dates[i]);
						i--;
					}
					
				}
				else
				{
					dates.Remove(dates[i]);
					i--;
				}
								
			}


            var culture = CultureInfo.CreateSpecificCulture("fr-CA");

            for (int i = 0; i < dates.Count; i++)
            {
                 Console.WriteLine(DateTime.ParseExact(dates[i], "d.M.yyyy", culture)); 
            }
            
		}
	}
}
