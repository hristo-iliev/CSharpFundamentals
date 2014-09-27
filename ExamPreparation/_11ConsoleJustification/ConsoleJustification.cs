namespace _11ConsoleJustification
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ConsoleJustification
    {
        private static int rowLength;

        public static void Build(Queue<string> words)
        {
            var res = new StringBuilder();
            while (words.Count != 0 || res.Length > 0)
            {
                if (res.Length == rowLength)
                {
                    if (res.ToString().LastIndexOf(" ") == res.Length - 1)
                    {
                        res.Remove(res.Length - 1, 1);
                    }
                    else
                    {
                        Console.WriteLine(res);
                        res.Clear();
                    }                    
                }

                if (words.Count > 0 && res.Length + words.Peek().Length == rowLength)
                {
                    res.Append(words.Dequeue());
                }
                else if (words.Count > 0 && res.Length + words.Peek().Length < rowLength)
                {
                    res.Append(words.Dequeue() + " ");
                }
                else
                {
                    if (res.ToString().LastIndexOf(" ") == res.Length - 1)
                    {
                        res.Remove(res.Length - 1, 1);
                    }

                    int start = 0;
                    string oldGab = " ";
                    ////string newGab = "  ";
                    if (res.ToString().IndexOf(oldGab) < 0)
                    {
                        Console.WriteLine(res);
                        res.Clear();
                    }
                    else
                    {
                        while (res.Length != rowLength)
                        {
                            if (res.ToString().IndexOf(oldGab, start) >= 0)
                            {
                                res.Insert(res.ToString().IndexOf(oldGab, start), (new string(' ', oldGab.Length)));
                                start = res.ToString().IndexOf(oldGab, start) + 2;
                            }
                            else
                            {
                                start = 0;
                                oldGab += " ";
                                ////newGab += " ";
                            }
                        }
                    }                    
                }
            }
        }

        public static void Main()
        {
            int red = int.Parse(Console.ReadLine());            
            rowLength = int.Parse(Console.ReadLine());
            Queue<string> words = new Queue<string>();            

            for (int i = 0; i < red; i++)
            {
                string[] x = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < x.Length; j++)
                {
                    words.Enqueue(x[j]);
                }
            }

            Build(words);
        }
    }
}
