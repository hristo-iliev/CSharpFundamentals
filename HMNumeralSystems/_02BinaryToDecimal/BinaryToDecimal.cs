//// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

public class BinaryToDecimal
{ 
    public static int ConvertBinaryToDecimal(string num)
    {
        int result = 0;

        for (int i = 0; i < num.Length; i++)
        {
            result += ((num[i] - '0') * (int)(Math.Pow(2, (num.Length - (1+i)))));
        }

        return result;
    }

    public static void Main()
    {
        Console.WriteLine("Enter a binary number:");
        string num = Console.ReadLine();


        Console.WriteLine(ConvertBinaryToDecimal(num));

    }
}

