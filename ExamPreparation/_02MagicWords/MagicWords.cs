////Variant 1 (2013-09-14, Morning)

namespace _02MagicWords
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    private class MagicWords
    {   
        private static void Main()
        {
            List<string> words = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }            

            for (int i = 0; i < n; i++)
            {
                int newIndex = words[i].Length % (n + 1);

                words.Insert(newIndex, words[i]);
                if (newIndex <= i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }                
            }

            StringBuilder result = new StringBuilder();            
            int wordCounter = 0;

            while (words.Count != 0)
            {
                for (int k = 0; k < words.Count; k++)
                {
                    if (wordCounter == words[k].Length)
                    {
                        words.RemoveAt(k);
                        k--;
                    }
                    else
                    {
                        result.Append(words[k][wordCounter]);
                    }                 
                }

                wordCounter++;
            }

            Console.WriteLine(result.ToString());        
        }
    }
}
