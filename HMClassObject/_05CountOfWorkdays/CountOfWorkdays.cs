//Write a method that calculates the number of workdays between today and given date,
//passed as parameter. Consider that workdays are all days from Monday to Friday
//except a fixed list of public holidays specified preliminary as array.

namespace _05CountOfWorkdays
{
    using System;

    public class CountOfWorkdays
    {
        public static void Main()
        {
            Console.WriteLine("Enter the date!");
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Month (in number): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime givenDate = new DateTime (year, month, day);

            DateTime currentDate = DateTime.Today;

            int workdays = 0;

            int currentYear = DateTime.Today.Year;

            DateTime[] holidays = new DateTime[15];
            holidays[0] = new DateTime(currentYear , 1, 1);
            holidays[1] = new DateTime(currentYear, 3, 3);
            holidays[2] = new DateTime(currentYear, 4, 18);
            holidays[3] = new DateTime(currentYear, 4, 19);
            holidays[4] = new DateTime(currentYear, 4, 20);
            holidays[5] = new DateTime(currentYear, 5, 1);
            holidays[6] = new DateTime(currentYear, 5, 6);
            holidays[7] = new DateTime(currentYear, 5, 24);
            holidays[8] = new DateTime(currentYear, 9, 6);
            holidays[9] = new DateTime(currentYear, 9, 22);
            holidays[10] = new DateTime(currentYear, 11, 1);
            holidays[11] = new DateTime(currentYear, 12, 24);
            holidays[12] = new DateTime(currentYear, 12, 25);
            holidays[13] = new DateTime(currentYear, 12, 26);
            holidays[14] = new DateTime(currentYear, 12, 31);            

            while (true)
            {
                bool isDayOff = false;
                if (currentDate == givenDate)
                {
                    break;
                }

                for (int i = 0; i < holidays.Length; i++)
                {
                    if (currentDate == holidays[i] || currentDate.DayOfWeek == DayOfWeek.Sunday || currentDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        isDayOff = true;
                        break;
                    }
                }

                if (!isDayOff)
                {
                    workdays++;
                }

               currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine();
            Console.WriteLine("There are {0} workdays in the given interval.", workdays);
        }
    }
}
