using System;
using System.Collections.Generic;
using System.Linq;
using _06ClassMatrix;

class ClassMatrix
{
    //Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and
    //multiplying of matrices, indexer for accessing the matrix content and ToString().

    static void Main()
    {
        Matrix mat1 = new Matrix(2, 2);
        mat1[0, 0] = 3;
        mat1[0, 1] = 12;
        mat1[1, 0] = 5;
        mat1[1, 1] = -2;
        Matrix mat2 = new Matrix(2, 2);
        mat2[0, 0] = 2;
        mat2[0, 1] = 6;
        mat2[1, 0] = 12;
        mat2[1, 1] = 7;

        

        Matrix sum = mat1 + mat2;
        Matrix sub = mat1 - mat2;
        Matrix mult = mat1 * mat2;

        Console.WriteLine(mat1.ToString());
        Console.WriteLine(mat2.ToString());

        Console.WriteLine(new string('~', 40));

        Console.WriteLine(sum.ToString());
        Console.WriteLine(sub.ToString());
        Console.WriteLine(mult.ToString());





    }
}

