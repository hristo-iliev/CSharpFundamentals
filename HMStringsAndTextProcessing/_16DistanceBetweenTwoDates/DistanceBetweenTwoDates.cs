//// Write a program that reads two dates in the format: day.month.year 
//// and calculates the number of days between them. 
//// Example:
//// Enter the first date: 27.02.2006
//// Enter the second date: 3.03.2004
//// Distance: 4 days


namespace _16DistanceBetweenTwoDates
{
    using System;

    public class DistanceBetweenTwoDates
    {
        public static void Main()
        {
            string firstDate = "27.02.2006";
            string secondDate = "3.03.2004";

            string[] oneStr = firstDate.Split('.');
            string[] twoStr = secondDate.Split('.');

            int[] one  = new int[oneStr.Length];
            int[] two= new int[oneStr.Length];

            for (int i = 0; i < oneStr.Length; i++)
            {
                one[i] = Convert.ToInt32(oneStr[i]);
                two[i] = Convert.ToInt32(twoStr[i]);
            }

            DateTime smaller = new DateTime(one[2], one[1], one[0]);
            DateTime second = new DateTime(two[2], two[1], two[0]);

            int biggerDate = Math.Max(one[2], two[2]) - Math.Min(one[2], two[2]);

            int days =smaller.Subtract(second).Days;    

            Console.WriteLine("First date: " + firstDate);
            Console.WriteLine("Second date: " + secondDate);
            Console.WriteLine();
            Console.Write("Days between them: ");
            Console.WriteLine(Math.Abs(days - 365*biggerDate)); 
        }                                                       
    }
}
