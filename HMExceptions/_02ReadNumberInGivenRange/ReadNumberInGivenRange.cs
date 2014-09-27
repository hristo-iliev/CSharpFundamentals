//// Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//// If an invalid number or non-number text is entered, the method should throw an exception.
//// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02ReadNumberInGivenRange
{
    using System;

    public class ReadNumberInGivenRange
    {
        private static int start = 1;
        private static int end = 100;

        public static void ReadNumber(int start, int end)
        {
            try
            {                
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Num[{0}] = ", i);
                    int num = int.Parse(Console.ReadLine());

                    if (num <= start || num >= end)
                    {
                        throw new ArgumentException("The entered number is out of range!");
                    }

                    start = num;
                }

                Console.WriteLine();
                Console.WriteLine("Welldone! You surrvived without any exceptions!");            
            }
            catch (FormatException ex)
            {                
                Console.Error.WriteLine("FormatException: The input should be an integer number! \n{0}", ex.StackTrace);                                
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }            
        }

        public static void Main()
        {
            ReadNumber(start, end);
        }
    }
}
