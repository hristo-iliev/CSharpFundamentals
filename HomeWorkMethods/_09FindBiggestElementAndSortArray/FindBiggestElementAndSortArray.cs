using System;
using System.Collections.Generic;


class FindBiggestElementAndSortArray
{
    // Write a method that return the maximal element in a portion of array of integers starting at given index.
    // Using it write another method that sorts an array in ascending / descending order.

    static int BiggestElementInTheArray(List<int> arr)
    {
        int biggestNum = arr[0];
        
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > biggestNum)
            {
                biggestNum = arr[i];
            }
        }
        return biggestNum;
    }

    static List<int> SortArrayDecreasing(List<int> arr)
    {
        List<int> sortedList = new List<int>();
        while (true)
        {
            sortedList.Add(BiggestElementInTheArray(arr));
            arr.Remove(BiggestElementInTheArray(arr));

            if (arr.Count == 0)
            {
                break;
            }
        }

        return sortedList;
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array length:");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of the array:");

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }

        List<int> sortedArray = SortArrayDecreasing(arr);

        foreach (var number in sortedArray)
        {
            Console.Write(number + " ");
        }
    }
}

