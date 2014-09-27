using System;
using System.Collections.Generic;
using System.Numerics;


class MinMaxAverageSumProduct
{
    //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    //Use variable number of arguments.

    static void Minimum(int[] arr)
    {
        Array.Sort(arr);

        Console.WriteLine("The number with minimal value is: " + arr[0]);
    }

    static void Maximum(int[] arr)
    {
        Array.Sort(arr);

        Console.WriteLine("The number with maximal value is: " + arr[arr.Length-1]);
    }

    static void Average(int[] arr)
    {
        int result = new int();

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        Console.WriteLine("The average number is: " + result / arr.Length);


    }

    static void Sum(int[] arr)
    {
        int result = new int();

        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }

        Console.WriteLine("The sum of the digits is: " + result);
    }

    static void Product(int[] arr)
    {
        BigInteger result = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            result *= arr[i];
        }

        Console.WriteLine("The product of the digits is: " + result);
    }

    

    static void Main()
    {
        int[] arr = { 4, 12, -5, 3, 7, 11, 4 };

        Minimum(arr);
        Maximum(arr);
        Average(arr);
        Sum(arr);
        Product(arr);

    }
}

