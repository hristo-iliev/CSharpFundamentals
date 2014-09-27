using System;
using System.Collections.Generic;
using System.Linq;
class BinarySearch
{
    //Write a program, that reads from the console an array of N integers and an integer K,
    //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 



    static void Main()
    {
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.WriteLine(new string('-', 40));
        if (Array.BinarySearch(arr,k) < 0)
        {
            Console.WriteLine("K is not found");
        }
        else if (Array.BinarySearch(arr,k) == 0)
        {
            Console.WriteLine("The largest number which is <= K is:  {0}", arr[0]);
        }
        else
        {
            Console.WriteLine("The largest number which is <= K is:  {0}", arr[Array.BinarySearch(arr,k) - 1]);
        }

    }
}

