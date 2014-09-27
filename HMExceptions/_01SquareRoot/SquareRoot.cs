//// Write a program that reads an integer number and calculates and prints its square root.
//// If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye".
//// Use try-catch-finally.

namespace _01SquareRoot
{    
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            int a;
            try
            {
                a = int.Parse(Console.ReadLine());

                if (a < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                else
                {
                    Console.WriteLine("The square root is: {0}", Math.Sqrt(a));
                }


            }
            catch (Exception)
            {

                Console.Error.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
