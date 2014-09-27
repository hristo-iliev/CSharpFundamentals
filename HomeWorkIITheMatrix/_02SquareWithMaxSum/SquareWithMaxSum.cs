using System;
using System.Collections.Generic;
class SquareWithMaxSum
{
    // Write a program that reads a rectangular matrix of size N x M
    // and finds in it the square 3 x 3 that has maximal sum of its elements.

    static int[] BestSquare(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int[] bestSquare = new int[9];

        

        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
           

            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                int currentSum = 0;
                List<int> currentSquare = new List<int>();

                for (int currentRow = row; currentRow < row+3; currentRow++)
                {
                   

                    for (int currentCol = col; currentCol < col+3; currentCol++)
                    {
                        currentSum += matrix[currentRow, currentCol];
                        currentSquare.Add(matrix[currentRow, currentCol]);

                    }

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestSquare = currentSquare.ToArray();


                        
                    }
                }
            }
        }

        Console.WriteLine("The best sum is: " + bestSum);
        

        return bestSquare;



    }

    static void Print(int[] square)
    {
        Console.WriteLine(new string('-', 40));
        for (int row = 0; row < square.Length;)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(square[row] + " ");
                row++;
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        

        int[,] matrix = 
        {
            {2, 8, 1, 14, 16, 22, 3, -1},
            {4, 5, 24, 17, 3, 3, 4, 12},
            {8, -10, 18, -5, 2, -9, 13, 5},
            {30, 1, 4, 24, 19, 3, 7, -2}
        };

        Print(BestSquare(matrix));

        
    }
}

