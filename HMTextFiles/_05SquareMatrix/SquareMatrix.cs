//// Write a program that reads a text file containing a square matrix of numbers
//// and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//// The first line in the input file contains the size of matrix N. 
//// Each of the next N lines contain N numbers separated by space.
//// The output should be a single number in a separate text file.

namespace _05SquareMatrix
{
    using System;
    using System.IO;

    public class SquareMatrix
    {
        public static int[,] CreateMatrixFromTextFile(StreamReader squareMatrix)
        {
            int matrixLength = Convert.ToInt32(squareMatrix.ReadLine());
            string line = string.Empty;
            int[,] matrix = new int[matrixLength, matrixLength];

            using (squareMatrix)
            {
                int row = 0;

                while (true)
                {
                    int col = 0;

                    line = squareMatrix.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    string number = string.Empty;                    

                    for (int i = 0; i <= line.Length; i++)
                    {
                        if (i == line.Length || line[i] == ' ')
                        {
                            matrix[row, col] = Convert.ToInt32(number);
                            number = "";
                            col++;
                        }
                        else
                        {
                            number += line[i];
                        }
                    }
                    
                    row++;
                }
            }

            return matrix;
        }

        public static int[][] MaximalSumArea(int[,] matrix)
        {
            int[][] result = new int[2][];
            result[0] = new int[2];
            result[1] = new int[3];           

            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1 ; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentsum = (matrix[row, col] + matrix[row+1, col] + matrix[row, col+1] + matrix[row+1, col+1]);

                    if (currentsum > bestSum)
                    {                        
                        bestSum = currentsum;

                        result[0][0] = matrix[row,col];
                        result[0][1] = matrix[row, col+1];
                        result[1][0] = matrix[row+1, col];
                        result[1][1] = matrix[row+1, col+1];
                    }
                }
            }

            result[1][2] = bestSum;
            return result;
        }

        public static void PrintBestArea(int[][] input)
        {
            Console.WriteLine("Best area:");
            for (int row = 0; row <  2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(input[row][col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Maximal sum: {0}", input[1][2]);
        }

        public static void Main()
        {
            StreamReader squareMatrix = new StreamReader(@"../../../Files/05. Matrix.txt");
            int[,] matrix = CreateMatrixFromTextFile(squareMatrix);
            int[][] bestArea = MaximalSumArea(matrix);
            PrintBestArea(bestArea);            
        }
    }
}
