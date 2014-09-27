namespace _15CSharp_Brackets
{
    using System;
    using System.Text;

    public class Program
    {
        private static string tab;
        private static int numberOftab = 0;

        public static void Print(string input)
        {
            var res = new StringBuilder();            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    if (res.Length > 0)
                    {
                        for (int j = 0; j < numberOftab; j++)
                        {
                            Console.Write(tab);
                        }

                        Console.WriteLine(res);
                        res.Clear();
                    }

                    for (int j = 0; j < numberOftab; j++)
                    {
                        Console.Write(tab);
                    }

                    numberOftab++;
                    Console.WriteLine('{');
                }
                else if (input[i] == '}')
                {
                    if (res.Length > 0)
                    {
                        for (int j = 0; j < numberOftab; j++)
                        {
                            Console.Write(tab);
                        }

                        Console.WriteLine(res);
                        res.Clear();
                    }

                    numberOftab--;
                    for (int j = 0; j < numberOftab; j++)
                    {
                        Console.Write(tab);
                    }
                    
                    Console.WriteLine('}');
                }
                else
                {
                    if (input[i] == ' ')
                    {
                        if (res.Length > 0)
                        {
                            if (res[res.Length - 1] != ' ')
                            {
                                res.Append(input[i]);
                            }
                        }                      
                    }
                    else
                    {
                        res.Append(input[i]); 
                    }                  
                }
            }

            if (res.Length > 0)
            {
                for (int j = 0; j < numberOftab; j++)
                {
                    Console.Write(tab);
                }

                Console.WriteLine(res);
                res.Clear();
            }
        }

        public static void Main()
        {
            int len = int.Parse(Console.ReadLine());
            tab = Console.ReadLine();
            tab = tab.Trim(new char[] { ' ' });

            for (int i = 0; i < len; i++)
            {
                string line = Console.ReadLine();
                line = line.Trim(new char[] { ' ' });

                if (line != string.Empty)
                {
                    Print(line);
                }                
            }
        }
    }
}
