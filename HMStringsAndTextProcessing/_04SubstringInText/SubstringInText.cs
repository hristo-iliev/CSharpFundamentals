//// Write a program that finds how many times a substring is contained in a given text
//// (perform case insensitive search).

namespace _04SubstringInText
{
    using System;

    public class SubstringInText
    {
        public static void Main()
        {
            string text = @"We are living in an yellow submarine. We don't have anything else. 
                            Inside the submarine is very tight.
                            So we are drinking all the day. We will move out of it in 5 days.";

            string lowerText = text.ToLower();

            string searchedWord = "in";

            int getIndex = 0;
            int counter = 0;


            for (int i = 0; i < lowerText.Length; i++)
            {
                getIndex = lowerText.IndexOf(searchedWord, i); 
                                                               
                if (getIndex == -1)
                {
                    break;                                     
                }
                i = getIndex;
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("The word \"{0}\" appears  {1}  times in the given text.", searchedWord, counter);

        }
    }
}
