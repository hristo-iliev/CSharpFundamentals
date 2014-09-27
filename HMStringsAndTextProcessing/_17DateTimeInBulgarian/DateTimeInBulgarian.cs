//// Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//// and prints the date and time after 6 hours and 30 minutes (in the same format)
//// along with the day of week in Bulgarian.

namespace _17DateTimeInBulgarian
{
    using System;
    using System.Text;

    public class DateTimeInBulgarian
    {
        public static void Main()
        {            
            Console.OutputEncoding = Encoding.UTF8; 

            DateTime date = new DateTime(2010, 12, 07, 3, 45, 18); 

            DateTime output = date.AddHours(6); 
            output = output.AddMinutes(30);

            string format = "dd.MM.yyyy  HH:mm:ss ";    
            Console.WriteLine(output.ToString(format));

            format = "ddd";            
            switch(output.ToString(format)) 
            {
                case "Mon":
                    Console.WriteLine("Понеделник");
                    break;
                case "Tue":
                    Console.WriteLine("Вторник");
                    break;
                case "Wed":
                    Console.WriteLine("Сряда");
                    break;
                case "Thu":
                    Console.WriteLine("Четвъртък");
                    break;
                case "Fri":
                    Console.WriteLine("Петък");
                    break;
                case "Sat":
                    Console.WriteLine("Събота");
                    break;
                case "Sun":
                    Console.WriteLine("Неделя");
                    break;
                default:
                    break;
            }
        }
    }
}
