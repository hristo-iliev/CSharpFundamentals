﻿//// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;

public class BinaryToHexadecimal
{
    static string ConvertBinaryToHexadecimal(string num)
    {
        string result = string.Empty;     
        
        for (int i = 0; i < num.Length; i +=4)
        {
            string currentNum = "";
            for (int j = i; j < i+4; j++)
            {
                currentNum += num[j];
            }

            switch (currentNum)
            {
                case "0000":
                    result += "0";
                    break;
                case "0001":
                    result += "1";
                    break;
                case "0010":
                    result += "2";
                    break;
                case "0011":
                    result += "3";
                    break;
                case "0100":
                    result += "4";
                    break;
                case "0101":
                    result += "5";
                    break;
                case "0110":
                    result += "6";
                    break;
                case "0111":
                    result += "7";
                    break;
                case "1000":
                    result += "8";
                    break;
                case "1001":
                    result += "9";
                    break;
                case "1010":
                    result += "A";
                    break;
                case "1011":
                    result += "B";
                    break;
                case "1100":
                    result += "C";
                    break;
                case "1101":
                    result += "D";
                    break;
                case "1110":
                    result += "E";
                    break;
                case "1111":
                    result += "F";
                    break;
                default:
                    break;
            }
        }

        result = result.TrimStart(new char[] { '0' });

        return result;
    }
    public static void Main()
    {
        Console.WriteLine("Enter a 32 bit binary number:");
        string bin = Console.ReadLine();

        int num = Convert.ToInt32(bin, 2);

        bin = Convert.ToString(num, 2).PadLeft(32, '0');

        Console.WriteLine(ConvertBinaryToHexadecimal(bin));

        
    }
}

