using System;
using System.Collections.Generic;
using System.Linq;


class SortingByTheLengthOfTheElements
{
    //You are given an array of strings. Write a method that sorts the array by the length of its elements 
    //(the number of characters composing them).


    static string[] QuickSort(string[] arr)
    {
        int pivot = arr.Length / 2;

        if (arr.Length <= 1)
        {
            return arr;
        }

        List<string> smaller = new List<string>();
        List<string> bigger = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != pivot)
            {
                if (arr[i].Length <= arr[pivot].Length)
                {
                    smaller.Add(arr[i]);
                }
                else
                {
                    bigger.Add(arr[i]);
                }
            }


        }

        return Concat(QuickSort(smaller.ToArray()), QuickSort(bigger.ToArray()), arr[pivot]);

    }

    static string[] Concat(string[] smaller, string[] bigger, string pivot)
    {
        List<string> sortedArray = new List<string>();

        for (int i = 0; i < smaller.Length; i++)
        {
            sortedArray.Add(smaller[i]);
        }

        sortedArray.Add(pivot);

        for (int i = 0; i < bigger.Length; i++)
        {
            sortedArray.Add(bigger[i]);
        }

        return sortedArray.ToArray();
    }

    static void PrintArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    static void Main()
    {
        string[] arr = { "Pig", "Osama", "Sandokan", "Kolio", "BGN", "No", "Ferrari" };

        PrintArray(QuickSort(arr));

    }
}

