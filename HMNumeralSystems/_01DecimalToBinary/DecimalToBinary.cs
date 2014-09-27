//// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
public class DecimalToBinary
{      
    public static int[] ConvertDecimalToBinary(int num)
    {
        List<int> binaryNum = new List<int>();
        while (num > 0)
        {
            binaryNum.Add(num % 2);
            num = num / 2;
        }

        int[] result = binaryNum.ToArray();
        Array.Reverse(result);
        return result;
    }

    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);

        }

        Console.Write("b");
        Console.WriteLine();
    }
    public static void Main()
    {
        Console.Write("N = ");
        int num = int.Parse(Console.ReadLine());

        Print(ConvertDecimalToBinary(num));

    }
}

