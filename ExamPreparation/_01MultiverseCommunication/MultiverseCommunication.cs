////Variant 1 (2013-09-14, Morning)

namespace _01MultiverseCommunication
{
    using System;
    using System.Collections.Generic;
    using System.Text;    

    public class MultiverseCommunication
    {
        public static long NumberToDecimal(string num, int numSystem)
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
                        result += (num[i] - '0') * (long)(Math.Pow(numSystem, (num.Length - (i + 1))));
                        break;
                }
            }

            return result;
        }

        public static string DecimalToAnyNumeralSystem(long num, int toSystem)
        {
            List<long> hexNum = new List<long>();

            while (num > 0)
            {
                hexNum.Add(num % toSystem);
                num = num / toSystem;
            }

            string result = String.Empty;

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
                    result += hexNum[i].ToString();
                }
            }

            return result;
        }

        public static string FromMultiverseTo13NumSystem(string num)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < num.Length; i += 3)
            {
                if (num[i] == 'T')
                {
                    output.Append("1");
                }
                else if (num[i] == 'V')
                {
                    output.Append("5");
                }
                else if (num[i] == 'O')
                {
                    output.Append("2");
                }
                else if (num[i] == 'K')
                {
                    output.Append("9");
                }
                else if (num[i] == 'Y')
                {
                    output.Append("B");
                }
                else if (num[i] == 'C')
                {
                    if (num[i + 1] == 'H')
                    {
                        output.Append("0");
                    }
                    else if (num[i + 1] == 'A')                                 
                    {
                        output.Append("8");
                    }
                    
                }
                else if (num[i] == 'I')
                {
                    if (num[i + 1] == 'V')
                    {
                        output.Append("3");
                    }
                    else if (num[i + 1] == 'I')                                  
                    {
                        output.Append("A");
                    }

                }
                else if (num[i] == 'E')
                {
                    if (num[i + 1] == 'M')
                    {
                        output.Append("4");
                    }
                    else if (num[i + 1] == 'R')                                
                    {
                        output.Append("7");
                    }

                }
                else if (num[i] == 'P')
                {
                    if (num[i + 1] == 'O')
                    {
                        output.Append("6");
                    }
                    else if (num[i + 1] == 'L')                                  
                    {
                        output.Append("C");
                    }
                }
            }

            return output.ToString();
        }

        public static void Main()
        {   
            string num = Console.ReadLine();
            num = FromMultiverseTo13NumSystem(num);         
                       
            Console.WriteLine(DecimalToAnyNumeralSystem(NumberToDecimal(num, 13), 10));
        }
    }
}
