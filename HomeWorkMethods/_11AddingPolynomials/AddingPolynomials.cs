using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below: x2 + 5 = 1x2 + 0x + 5 => 5 0 1

    static string CreatingPolynomial(int[] poly)
    {

        string polynomial = "";

        for (int i = 0; i < poly.Length; i++)
        {
            if (i == poly.Length - 1)
            {
                if (poly[poly.Length - 1] != 0)
                {
                    if (poly[poly.Length - 1] < 0)
                    {
                        polynomial += "- ";
                    }
                    else if (poly[poly.Length - 1] > 0)
                    {
                        polynomial += "+ ";
                    }
                    polynomial += Math.Abs(poly[poly.Length - 1]);
                }
            }
            else if (i == poly.Length - 2)
            {
                if (poly[poly.Length - 2] != 0)
                {
                    if (poly[poly.Length - 2] < 0)
                    {
                        polynomial += "- ";
                    }
                    else if (poly[poly.Length - 2] > 0)
                    {
                        polynomial += "+ ";
                    }
                    
                    if (poly[poly.Length - 2] == 1)
                    {
                        polynomial +=  "x ";
                    }
                    else
                    {
                        polynomial += Math.Abs(poly[poly.Length - 2]) + "x ";
                    }
                    
                }
            }
            else if (i==0)
            {
                if (poly[i] != 0)
                {
                    if (poly[i] == 1)
                    {
                        polynomial += "x^" + (poly.Length - (i + 1)) + " ";
                    }
                    else
                    {
                        polynomial += poly[i] + "x^" + (poly.Length - (i + 1)) + " ";
                    }
                    
                }
            }
            else
            {
                if (poly[i] != 0)
                {
                    if (poly[i] < 0)
                    {
                        polynomial += "- ";
                    }
                    else if (poly[i] > 0)
                    {
                        polynomial += "+ ";
                    }
                    
                    if (poly[i] == 1)
                    {
                        polynomial += "x^" + (poly.Length - (i + 1)) + " ";
                    }
                    else
                    {
                        polynomial += Math.Abs(poly[i]) + "x^" + (poly.Length - (i + 1)) + " ";
                    }
                    
                }
            }
        }

        return polynomial;
    }

    static int[] Adding(int[] first, int[] second)
    {
        int[] sum = new int[Math.Max(first.Length, second.Length)];

        Array.Reverse(first);
        Array.Reverse(second);

        int i = 0;
        for (; i < Math.Min(first.Length, second.Length); i++)
        {
            sum[i] = first[i] + second[i];
        }
        for (; i < first.Length; i++)
		{
            sum[i] = first[i];
		}
        for (; i < second.Length; i++)
		{
            sum[i] = second[i];
		}

        Array.Reverse(sum);

        return sum;
    }

    static void Main()
    {
        int[] firstPolynomialCoefficients = {4, 6, 2};
        int[] secondPolynomialCoefficients = { 8, -5, 7 };


        Console.WriteLine("First polynomial:   " + CreatingPolynomial(firstPolynomialCoefficients));
        Console.WriteLine("Second polynomial:  " + CreatingPolynomial(secondPolynomialCoefficients));

        Console.WriteLine(new string('~', 40));

        Console.WriteLine("Adding:  " + CreatingPolynomial(Adding(firstPolynomialCoefficients, secondPolynomialCoefficients)));




    }
}

