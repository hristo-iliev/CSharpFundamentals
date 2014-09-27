namespace _07Zerg___
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        static string[] zerg = 
        {"Rawr","Rrrr","Hsst","Ssst","Grrr","Rarr","Mrrr","Psst","Uaah","Uaha","Zzzz","Bauu","Djav","Myau","Gruh"};

        static string ToNum(string input)
        {
            var res = new StringBuilder();

            for (int i = 0; i < input.Length; i+=4)
            {
                string cur = input.Substring(i,4);

                int inx = Array.IndexOf(zerg, cur);
                if (inx < 10)
                {
                    res.Append(Array.IndexOf(zerg, cur));
                }
                else
                {
                    switch (inx)
                    {
                        case 10:
                            res.Append('A');
                            break;
                        case 11:
                            res.Append('B');
                            break;
                        case 12:
                            res.Append('C');
                            break;
                        case 13:
                            res.Append('D');
                            break;
                        case 14:
                            res.Append('E');
                            break;

                    }
                }                
            }

            return res.ToString();
        }

        static long NumberToDecimal(string num, int numSystem)
        {
            long result = 0;

            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case 'A':
                        result += (num[i] - 'A' + 10) * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                    case 'B':
                        result += (num[i] - 'A' + 10) * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                    case 'C':
                        result += (num[i] - 'A' + 10) * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                    case 'D':
                        result += (num[i] - 'A' + 10) * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                    case 'E':
                        result += (num[i] - 'A' + 10) * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                    case 'F':
                        result += (num[i] - 'A' + 10) * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                    default:
                        result += (num[i] - '0') * (long)(Math.Pow(numSystem, (num.Length - (i + 1)))); ;
                        break;
                }
            }

            return result;
        }

        static string DecimalToAnyNumeralSystem(long num, int toSystem)
        {
            List<long> hexNum = new List<long>();

            while (num > 0)
            {
                hexNum.Add(num % toSystem);
                num = num / toSystem;
            }

            string result = string.Empty;

            for (int i = hexNum.Count - 1; i >= 0; i--)
            {
                if (hexNum[i] > 10)
                {
                    switch (hexNum[i])
                    {
                        case 10:
                            result += "A";
                            break;
                        case 11:
                            result += "B";
                            break;
                        case 12:
                            result += "C";
                            break;
                        case 13:
                            result += "D";
                            break;
                        case 14:
                            result += "E";
                            break;
                        case 15:
                            result += "F";
                            break;
                        default:
                            break;

                    }
                }
                else
                {
                    result += (hexNum[i].ToString());
                }
            }

            return result;
        }      
       
        static void Main()
        {
            string input = "UaahMyauMyauRrrrMyauUaahUaah";
            //string input = Console.ReadLine();

            string num = ToNum(input);           
            
            Console.WriteLine((NumberToDecimal(num, 15)));
        }
    }
}
