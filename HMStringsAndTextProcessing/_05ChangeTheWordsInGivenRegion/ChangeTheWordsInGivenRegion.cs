//You are given a text. Write a program that changes the text in all regions
//surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.

namespace _05ChangeTheWordsInGivenRegion
{
    using System;
    using System.Text;

    public class ChangeTheWordsInGivenRegion
    {
        public static string Transform(string input)
        {
                       

            StringBuilder transform = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')       
                {
                    bool closingTag = false;
                    if (input[i+1] == '/')      
                    {
                        closingTag = true;
                    }
                    if (input.IndexOf(">", i) == -1) 
                    {
                        throw new ArgumentException("Invalid Input!");
                    }
                    while (input[i] != '>')    
                    {
                        i++;
                    }
                    

                    if (!closingTag)        
                    {
                        i++;                
                        while (i != input.Length && input[i] != '<')
                        {
                            transform.Append(input[i].ToString().ToUpper()); 
                            i++;
                        }
                    }
                    
                    if (i < input.Length && input[i] == '<')
                    {
                        i--;        
                    }               
                }
                else
                {
                    transform.Append(input[i]);
                }
            }

            return transform.ToString();
        }
        public static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            Console.WriteLine("Result:");
            Console.WriteLine();
            Console.WriteLine(Transform(text));
            Console.WriteLine();
        }
    }
}
