using System;
using System.Collections.Generic;

class LastDigitAsWord
{
    // Write a method that returns the last digit of given integer as an English word. 
    // Examples: 512  "two", 1024  "four", 12309  "nine".

    static void PrintLastDigitAsWord(string number)
    {
        switch (number[number.Length -1])
        {
            case '1':
                Console.WriteLine("One");
                break;
            case '2':
                Console.WriteLine("Two");
                break;
            case '3':
                Console.WriteLine("Three");
                break;
            case '4':
                Console.WriteLine("Four");
                break;
            case '5':
                Console.WriteLine("Five");
                break;
            case '6':
                Console.WriteLine("Six");
                break;
            case '7':
                Console.WriteLine("Seven");
                break;
            case '8':
                Console.WriteLine("Eight");
                break;
            case '9':
                Console.WriteLine("Nine");
                break;
            case '0':
                Console.WriteLine("Zero");
                break;
            default:
                break;

        }
    }

    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        Console.Write("N = ");
        string n = Console.ReadLine();

        PrintLastDigitAsWord(n);
                
    }
}

