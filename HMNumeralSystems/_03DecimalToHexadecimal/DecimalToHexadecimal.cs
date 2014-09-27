//// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

public class DecimalToHexadecimal
{      
    public static string ConvertDecimalToHexadecimal(int num)
    {
        List<int> hexNum = new List<int>();

        while (num > 0)
        {
            hexNum.Add(num % 16);
            num = num / 16;
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
                        result+= "B";
                        break;
                    case 12:
                        result+= "C";
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
        Console.Write("N = ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToHexadecimal(num));
    }
}

