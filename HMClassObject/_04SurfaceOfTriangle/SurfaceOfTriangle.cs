////Write methods that calculate the surface of a triangle by given:
////Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

namespace _04SurfaceOfTriangle
{
    using System;   

    public class SurfaceOfTriangle
    {
        
        public static decimal SurBySideAndAltitude(decimal a, decimal h)
        {
            decimal surface = (a * h) / 2;
            
            return surface;
        }

        public static double SurByThreeSides(decimal a, decimal b, decimal c)
        {
            decimal p = (a + b + c);   //half perimeter
            decimal surface = (p * (p - a) * (p - b) * (p - c));

            double result = Math.Sqrt(Convert.ToDouble(surface));

            return result;
        }

        public static double SurByTwoSidesAndAngle(double a, double b, double y)
        {
            double surface = (a * b * (Math.Sin(y))) / 2;

            return surface;
        }

        public static void Main()
        {
            Console.WriteLine("Choose the way to calculate the surface of a triangle:");
            Console.WriteLine("By given:");
            Console.WriteLine("1) Side and an altitude.");
            Console.WriteLine("2) Three sides.");
            Console.WriteLine("3) Two sides and an angle between them.");
            Console.WriteLine();
            Console.Write("Type the corresponding number of your choise: ");
            int choise = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choise == 1)
            {
                Console.WriteLine("Enter the side \"a\" and the altitude \"h\":");
                Console.Write("a = ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("h = ");
                decimal h = decimal.Parse(Console.ReadLine());

                Console.WriteLine(new string('-', 40));
                Console.WriteLine("S = " + SurBySideAndAltitude(a, h));
            }
            else if (choise == 2)
            {
                Console.WriteLine("Enter the sides \"a\", \"b\", \"c\":");
                Console.Write("a = ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("b = ");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.Write("c = ");
                decimal c = decimal.Parse(Console.ReadLine());
                

                Console.WriteLine(new string('-', 40));
                Console.WriteLine("S = " + SurByThreeSides(a, b, c));
            }
            else if (choise == 3)
            {
                Console.WriteLine("Enter the sides \"a\", \"b\" and the angle \"y\":");
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("y = ");
                double y = double.Parse(Console.ReadLine());

                Console.WriteLine(new string('-', 40));
                Console.WriteLine("S = " + SurByTwoSidesAndAngle(a, b, y));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("ARE YOU STUPID! TYPE 1, 2 OR 3! #%%^&#$E@#$@#^%^&*");
            }          
        }
    }
}
