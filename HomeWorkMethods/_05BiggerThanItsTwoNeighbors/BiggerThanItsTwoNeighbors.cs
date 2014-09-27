using System;
using System.Collections.Generic;

class BiggerThanItsTwoNeighbors
{
    //Write a method that checks if the element at given position in given array of integers
    // is bigger than its two neighbors (when such exist).

    static void IsIntegerBiggersThanNeighbors(int position, int[] arr)
    {
        if (position < 0 || position >= arr.Length)
        {
            Console.WriteLine("Invalid position!");
        }
        else if (position > 0 && position < arr.Length-1)
        {
            if (Math.Max(arr[position],Math.Max(arr[position -1], arr[position+1])) == arr[position])
            {
                Console.WriteLine("The element in position {0} is bigger than it's neighbors.", position);
            }
            else
            {
                Console.WriteLine("The element in position {0} is smaller than it's neighbors.", position);
            }
        }
        else if (position == 0)
        {
            if(Math.Max(arr[position], arr[position+1]) == arr[position])
            {
                Console.WriteLine("The element in position {0} is bigger than it's neighbors.", position);
            }
            else
            {
                Console.WriteLine("The element in position {0} is smaller than it's neighbors.", position);
            }
        }
        else if (position == arr.Length -1)
        {
            if (Math.Max(arr[position], arr[position - 1]) == arr[position])
            {
                Console.WriteLine("The element in position {0} is bigger than it's neighbors.", position);
            }
            else
            {
                Console.WriteLine("The element in position {0} is smaller than it's neighbors.", position);
            }
        }
        
    }

    static void Main()
    {
        Console.WriteLine("Enter the wanted position:");
        Console.Write("P = ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array length:");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of the array:");

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 30));
        IsIntegerBiggersThanNeighbors(p , arr);

    }
}

