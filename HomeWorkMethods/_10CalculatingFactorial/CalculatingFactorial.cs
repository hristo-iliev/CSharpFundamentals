using System;
using System.Collections.Generic;

class CalculatingFactorial
{
    // Write a program to calculate n! for each n in the range [1..100]. 
    // Hint: Implement first a method that multiplies a number
    // represented as array of digits by given integer number. 


    static int Recurs(int n)
    {
        int result = (n - 1) + (n - 2);
        

        if (n <= 2)
        {
            Console.WriteLine("first "+ result);
            return 1;
        }
        else
        {
            Console.WriteLine(result);
            return (Recurs(n - 1) + (Recurs(n - 2)));

            
        }
        Console.WriteLine(result);
    }

    static void Main()
    {

        int n = 100;

        Console.WriteLine(Recurs(n));




    }
}

