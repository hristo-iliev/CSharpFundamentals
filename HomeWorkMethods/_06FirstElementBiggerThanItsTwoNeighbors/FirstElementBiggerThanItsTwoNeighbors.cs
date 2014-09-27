using System;
using System.Collections.Generic;

class FirstElementBiggerThanItsTwoNeighbors
{
    //Write a method that returns the index of the first element in array that is bigger than its neighbors,
    //or -1, if there’s no such element. Use the method from the previous exercise.

    static void IsIntegerBiggersThanNeighbors(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            
            if (i > 0 && i < arr.Length - 1)
            {
                if (Math.Max(arr[i], Math.Max(arr[i - 1], arr[i + 1])) == arr[i])
                {
                    Console.WriteLine("The element in position {0} is bigger than it's neighbors.", i);
                    return;
                }
                
                
            }
            else if (i == 0)
            {
                if (Math.Max(arr[i], arr[i + 1]) == arr[i])
                {
                    Console.WriteLine("The element in position {0} is bigger than it's neighbors.", i);
                    return;
                }
                
            }
            else if (i == arr.Length - 1)
            {
                if (Math.Max(arr[i], arr[i - 1]) == arr[i])
                {
                    Console.WriteLine("The element in position {0} is bigger than it's neighbors.", i);
                    return;
                }
                
            }
        }

        Console.WriteLine("-1");
        return;
        

    }
    static void Main()
    {
        Console.WriteLine("Enter the array length:");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of the array:");

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(new string ('~',40));
        IsIntegerBiggersThanNeighbors(arr);
    }
}

