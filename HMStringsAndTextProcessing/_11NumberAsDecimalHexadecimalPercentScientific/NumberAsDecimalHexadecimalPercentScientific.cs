//// Write a program that reads a number and prints it as a decimal number, hexadecimal number,
//// percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace _11NumberAsDecimalHexadecimalPercentScientific
{
    using System;
    using System.Globalization;

    public class NumberAsDecimalHexadecimalPercentScientific
    {
        public static void Main()
        {
            int number = 25;

            Console.WriteLine("Decimal:     {0,15}", number.ToString("D", CultureInfo.InvariantCulture));
            Console.WriteLine("Hexadecimal: {0,15}", number.ToString("X", CultureInfo.InvariantCulture));
            Console.WriteLine("Percentage:  {0,15}", number.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine("Scientific:  {0,15}", number.ToString("E", CultureInfo.InvariantCulture));



        }
    }
}
