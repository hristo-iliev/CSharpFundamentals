//// Write a program for extracting all email addresses from given text.
//// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18ЕxtractingЕmailАddresses
{
    using System;
    using System.Collections.Generic;

    public class ЕxtractingЕmailАddresses
    {
        public static void Main()
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

            List<string> words = new List<string>();

            string[] arr = text.Split(' ');                                             

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].IndexOf('@') >= 0)
                {
                    words.Add(arr[i]);
                }
            }

            for (int i = 0; i < words.Count; i++) 
            {


                if (words[i][0] == '@') 
                {
                    words.Remove(words[i]);
                    i--;
                    
                }
                else if (words[i].IndexOf("@") - 3 < 0) 
                {
                    words.Remove(words[i]);
                    i--;
                }
                else if (words[i].IndexOf("@") + 4 >= words[i].Length) 
                {
                    words.Remove(words[i]);
                    i--;
                }
                else if ((words[i].IndexOf(".") + 1 >= words[i].Length))
                {
                    words.Remove(words[i]);
                    i--;
                }

            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);   
            }
        }
    }
}
