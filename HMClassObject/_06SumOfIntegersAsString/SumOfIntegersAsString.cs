////You are given a sequence of positive integer values written into a string,
////separated by spaces. Write a function that reads these values from given string and calculates their sum.
////Example: string = "43 68 9 23 318"  result = 461

namespace _06SumOfIntegersAsString
{
    using System;

    public class SumOfIntegersAsString
    {
        static void Main()
        {
            Console.WriteLine("Enter a string and check the integers sum in it!");
            Console.WriteLine("Example: string = 43 68 9 23 318  result = 461");
            Console.WriteLine();
            Console.Write("string = ");
            string numbers = Console.ReadLine();

            string[] nums = numbers.Split(' ');

            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result += Convert.ToInt32(nums[i]);
            }

            Console.WriteLine("The sum is: {0}", result);
        }
    }
}
