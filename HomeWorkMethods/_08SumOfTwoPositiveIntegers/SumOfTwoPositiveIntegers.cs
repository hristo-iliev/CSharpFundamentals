using System;
using System.Collections.Generic;

class SumOfTwoPositiveIntegers
{
    // Write a method that adds two positive integer numbers represented as arrays of digits 
    // (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    // Each of the numbers that will be added could have up to 10 000 digits.
    static string BiggerNumber(string first, string second)
    {
        string biggerNumber = "";
        if (first.Length > second.Length)
        {
            biggerNumber  = first;
        }
        else if (first.Length < second.Length)
        {
            biggerNumber = second;
        }

        return biggerNumber;
    }

    static string AddZerosToSmallersNumber(string first, string second)
    {
        string smallerNumber = "";
        
        for (int i = 0; i < Math.Max(first.Length, second.Length) - Math.Min(first.Length, second.Length); i++)
        {


            smallerNumber += '0';


        }
        if (first.Length > second.Length)
        {
            smallerNumber += second;
        }
        else if (first.Length < second.Length)
        {
            smallerNumber += first;
        }

        return smallerNumber;
    }

    static void SumNumbers(string first, string second)
    {
        string result = "";

        for (int i = 0; i < first.Length; i++)
        {
            if (i == 0)
            {
                if ((first[i] - '0') + (second[i] - '0') > 9)
                {
                    result += ((first[i] - '0') + (second[i] - '0')) / 10;
                }
            }

            if (i == first.Length - 1)
            {
                result += ((first[i] - '0') + (second[i] - '0')) % 10;
                break;
            }
            else
            {
                result += ((first[i] - '0') + (second[i] - '0')) % 10 + ((first[i + 1] - '0') + (second[i + 1] - '0')) / 10;
            }

            
        }

        Console.WriteLine(result);
    }


    static void Main()
    {
        Console.Write("N = ");
        string n = Console.ReadLine();
        Console.Write("K = ");
        string k = Console.ReadLine();

        Console.WriteLine(new string('-',40));

        if (n.Length == k.Length)
        {
            SumNumbers(n,k);
        }
        else
        {
            SumNumbers(BiggerNumber(n, k), AddZerosToSmallersNumber(n, k));
        }
    }
}

