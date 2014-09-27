using System;
using System.Collections.Generic;


class GetMaxTask
{
    // Write a method GetMax() with two parameters that returns the bigger of two integers.
    // Write a program that reads 3 integers from the console and prints the biggest of them
    // using the method GetMax().


    static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }

    static void Main()
    {
        Console.WriteLine("Enter three integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('~', 30 ));
        Console.WriteLine("The biggest integer is  ->  {0}",GetMax(GetMax(a,b),c));
    }
}

