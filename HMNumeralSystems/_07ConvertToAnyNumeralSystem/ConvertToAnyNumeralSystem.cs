//// Write a program to convert from any numeral system of given base s to any other numeral system of base 
//// d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;

public class ConvertToAnyNumeralSystem
{
    public static long NumberToDecimal(string num, long numSystem)
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

    public static string DecimalToAnyNumeralSystem(long num, long toSystem)
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

    public static void Main()
    {

        Console.WriteLine("Enter the base of the input and output Numeral Systems!");
        Console.Write("Convert FROM: ");
        long fromSystem = long.Parse(Console.ReadLine());
        Console.Write("Convert TO: ");
        long toSystem = long.Parse(Console.ReadLine());

        Console.Write("Number = ");
        string num = Console.ReadLine();

        Console.WriteLine(new string('-', 40));

        Console.Write("RESULT: ");
        Console.WriteLine(DecimalToAnyNumeralSystem(NumberToDecimal(num, fromSystem), toSystem));
    }
}

