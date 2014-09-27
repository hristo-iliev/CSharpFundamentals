using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace _15GenericMethod
{
    class GenericMethod
    {
        //* Modify your last program and try to make it work for any number type, not just integer 
        //  (e.g. decimal, float, byte, etc.). Use generic method.

        static void Minimum<T>(T[] arr)
        {
            Array.Sort(arr);

            Console.WriteLine("The number with minimal value is: " + arr[0]);
        }

        static void Maximum<T>(T[] arr)
        {
            Array.Sort(arr);

            Console.WriteLine("The number with maximal value is: " + arr[arr.Length - 1]);
        }


        static void Average<T>(T[] arr)
        {
            dynamic result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine("The average number is: " + result / arr.Length);


        }

        static void Sum<T>(T[] arr)
        {
            dynamic result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine("The sum of the digits is: " + result);
        }

        static void Product<T>(T[] arr)
        {
            dynamic result = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }

            Console.WriteLine("The product of the digits is: " + result);
        }

        

        static void Main()
        {
            //int[] arr = {4, 12, -5, 3, 7, 11, 4};
            decimal[] arr = {-2.2m , 5.73m, 12m, 11.05m, 3.3m};
            //float[] arr = {4.04f, 8.2f, 14f, 2.4f};
            //sbyte[] arr = {-10, 12, 47, 83, -3};
            //long[] arr = {3333333, 4, 15 };


            Minimum(arr);
            Maximum(arr);
            Average(arr);
            Sum(arr);
            Product(arr);
        }
    }
}
