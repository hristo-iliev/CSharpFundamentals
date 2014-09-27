//Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02TenRandomValues
{
    using System;

    public class TenRandomValues
    {
        public static void Main()
        {
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumber.Next(100, 201));
            }
        }
    }
}
