using System;
using System.Collections.Generic;

class NumberInArray
{
    // Write a method that counts how many times given number appears in given array. 
    // Write a test program to check if the method is working correctly.

    static void NumberFrequencyInArray(int[] arr, int num)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                counter++;
            }
        }
        if (counter == 1)
        {
            Console.WriteLine("There is {0} number with value {1} int the array.", counter, num);
        }
        else
        { 
            Console.WriteLine("There is {0} numbers with value {1} int the array.", counter, num); 
        }
    }


    static void Main()
    {
        Console.WriteLine("Enter the wanted number:");
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array length:");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of the array:");

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        NumberFrequencyInArray(arr, k);


    }
}

