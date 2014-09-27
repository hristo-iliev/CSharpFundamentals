using System;
using System.Collections.Generic;

class ReversedDigitsOfDecimal
{
    //Write a method that reverses the digits of given decimal number. Example: 256  652

    static void ReversedNumber(string n)
    {
        string newNumber = "";
        for (int i = n.Length-1; i >= 0; i--)
        {
            newNumber += n[i];
        }
        Console.WriteLine(newNumber);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter the decimal number:");
        Console.Write("N = ");
        string n = Console.ReadLine();

        n = n.TrimStart(new char[]{'-'});

        ReversedNumber(n);
    }
}

