using System;
using System.Collections.Generic;

class SubtractionAndMultiplicationPolynomials
{
    //Extend the program to support also subtraction and multiplication of polynomials.
            
        
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

    static int[] Subtraction(int[] first, int[] second)
    {
        int[] sum = new int[Math.Max(first.Length, second.Length)];

        Array.Reverse(first);
        Array.Reverse(second);

        int i = 0;
        for (; i < Math.Min(first.Length, second.Length); i++)
        {
            sum[i] = first[i] - second[i];
        }
        for (; i < first.Length; i++)
		{
            sum[i] = 0 - first[i];
		}
        for (; i < second.Length; i++)
		{
            sum[i] = 0 - second[i];
		}

        Array.Reverse(sum);

        return sum;
    }

   
    static int[] Multiplication(int[] first, int[] second)
    {
        int[] result = new int[first.Length + second.Length - 1];
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                int position = i + j;
                result[position] += (first[i] * second[j]);
            }
        }

        Array.Reverse(result);

        return result;
    }

    static void Main()
    {
        int[] firstPolynomialCoefficients = {4, 6, 2, 5};
        int[] secondPolynomialCoefficients = { 8, -5, 7 };


        Console.WriteLine("First polynomial:   " + CreatingPolynomial(firstPolynomialCoefficients));
        Console.WriteLine("Second polynomial:  " + CreatingPolynomial(secondPolynomialCoefficients));

        Console.WriteLine(new string('~', 40));

        Console.WriteLine("Subtraction:    " + CreatingPolynomial(Subtraction(firstPolynomialCoefficients, secondPolynomialCoefficients)));
        Console.WriteLine("Multiplication: " + CreatingPolynomial(Multiplication(firstPolynomialCoefficients, secondPolynomialCoefficients)));




    }


    
    
}

