//// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;

public class BinaryRepresentationOfShort
{
    public static int[] ShortToBinary(short num)
    {       
        List<int> binaryNums = new List<int>();
        int[] finalBinary = new int[16];
        
        if (num >= 0)
        {
            while (num != 0)
            {
                binaryNums.Add(num % 2);
                num = (short)(num / 2);

            }

            for (int i = 0; i < 16; i++)
            {
                if (i == binaryNums.Count)
                {
                    binaryNums.Add(0);
                }
            }

            int idx = 0;
            foreach (var digit in binaryNums)
            {
                finalBinary[idx++] = digit;
            }           
        }
        else
        {
            short currentNum = Math.Abs(num);            
            while (currentNum != 0)
            {
                binaryNums.Add((currentNum % 2));
                currentNum = (short)(currentNum / 2);

            }

            for (int i = 0; i < 16; i++)
            {
                if (i == binaryNums.Count)
                {
                    binaryNums.Add(0);
                }
            }

            int idx = 0;
            foreach (var digit in binaryNums)
            {
                finalBinary[idx++] = digit^1;
            }

            for (int i = 0; i < 16; i++)
            {
                if (finalBinary[i] == 0)
                {
                    finalBinary[i] = 1;
                    break;
                }
                else
                {
                    finalBinary[i] = 0;
                }
            }
        }

        Array.Reverse(finalBinary);
        return finalBinary;        
    }

    public static void Print(int[] binNumbers)
    {        
        Console.WriteLine(new string('-', 40));
        for (int i = 0; i < binNumbers.Length; i++)
        {
            Console.Write(binNumbers[i]);
        }
        Console.WriteLine("b");
    }

    public static void Main()
    {
        Console.WriteLine("Enter a number you want to convert!");
        Console.Write("N = ");
        short num = short.Parse(Console.ReadLine());       

        Print(ShortToBinary(num));
    }
}

