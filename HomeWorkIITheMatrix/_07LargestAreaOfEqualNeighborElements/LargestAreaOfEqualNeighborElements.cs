using System;
using System.Collections.Generic;
using System.Linq;

class LargestAreaOfEqualNeighborElements
{
    //* Write a program that finds the largest area of equal neighbor elements
    //  in a rectangular matrix and prints its size. 

    public static bool[,] visited;
    public static int[,] matrix;
    public static int bestScore = 0;
    public static int currentScore = 0;
    public static int bestNumber;
    public static int currentnumber;

    static void LargestArea(int row, int col)
    {
        visited[row, col] = true;
        currentScore++;

        while (true)
        {
            if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == matrix[row, col] && visited[row, col + 1] == false) //RIGHT
            {
                LargestArea(row, col + 1);
            }
            else if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == matrix[row, col] && visited[row + 1, col] == false) //DOWN
            {
                LargestArea(row + 1, col);
            }
            else if (col - 1 >= 0 && matrix[row, col - 1] == matrix[row, col] && visited[row, col - 1] == false) //LEFT
            {
                LargestArea(row, col - 1);
            }
            else if (row - 1 >= 0 && matrix[row - 1, col] == matrix[row, col] && visited[row - 1, col] == false) //UP
            {
                LargestArea(row - 1, col);
            }
            else
            {
                return;
            }
        }

        

    }

    static void Main()
    {
        matrix = new int[,]
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1}
        };

        visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentScore = 0;
                currentnumber = matrix[row, col];
                if (!visited[row, col])
                {
                    currentnumber = matrix[row, col];
                    LargestArea(row, col);

                }

                if (currentScore > bestScore)
                {
                    bestScore = currentScore;
                    bestNumber = currentnumber;
                }
            }
        }

        Console.WriteLine("The largest area is with value  {0}  and has  {1}  elements.", bestNumber, bestScore);


    }
}

