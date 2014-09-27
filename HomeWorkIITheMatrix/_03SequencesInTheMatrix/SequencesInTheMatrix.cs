using System;
using System.Collections.Generic;
using System.Linq;


class SequencesInTheMatrix
{
    //We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several
    //neighbor elements located on the same line, column or diagonal. Write a program that finds the longest
    //sequence of equal strings in the matrix.

    static string FindBestSequence(string[,] matrix, int m, int n)
    {
        
        int bestScore = 1;
        string bestSequence = matrix[0,0];


        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int currentScore = 1;
                string currentSequence = matrix[row, col];


                if (col + 1 < n && matrix[row, col + 1] == matrix[row, col])         // check Right sequence
                {
                    for (int currentCol = col + 1; currentCol < n; currentCol++)
                    {
                        currentScore++;
                        currentSequence += (" " + matrix[row, currentCol]);



                        if (currentCol + 1 == n || matrix[row, currentCol + 1] != matrix[row, currentCol])
                        {
                            break;
                        }
                    }

                    if (currentScore > bestScore)
                    {
                        bestScore = currentScore;
                        bestSequence = currentSequence;
                    }

                }

                currentScore = 1;
                currentSequence = matrix[row, col];

                if (row + 1 < m && matrix[row + 1, col] == matrix[row, col])          // check Down sequence
                {
                    for (int currentRow = row + 1; currentRow < m; currentRow++)
                    {
                        currentScore++;
                        currentSequence += (" " + matrix[currentRow, col]);


                        if (currentRow + 1 == m || matrix[currentRow + 1, col] != matrix[currentRow, col])
                        {
                            break;
                        }
                    }

                    if (currentScore > bestScore)
                    {
                        bestScore = currentScore;
                        bestSequence = currentSequence;
                                              
                    }
                }

                currentScore = 1;
                currentSequence = matrix[row, col];

                if (col + 1 < n && row + 1 < m && matrix[row + 1, col + 1] == matrix[row, col]) //Right Diagonal 
                {
                    int currentRow = row + 1;
                    int currentCol = col + 1;
                    while (true)
                    {

                        currentScore++;
                        currentSequence += (" " + matrix[currentRow, currentCol]);


                        if (currentRow + 1 == m || currentCol + 1 == n || matrix[currentRow + 1, currentCol + 1] != matrix[currentRow, currentCol])
                        {
                            break;
                        }
                        else
                        {
                            currentRow++;
                            currentCol++;
                        }
                    }

                    if (currentScore > bestScore)
                    {
                        bestScore = currentScore;
                        bestSequence = currentSequence;

                    }
                }

                currentScore = 1;
                currentSequence = matrix[row, col];

                if (col - 1 > -1 && row + 1 < m && matrix[row + 1, col - 1] == matrix[row, col]) //Left Diagonal
                {
                    int currentRow = row + 1;
                    int currentCol = col - 1;

                    while (true)
                    {
                        currentScore++;
                        currentSequence += (" " + matrix[currentRow, currentCol]);


                        if (currentRow - 1 == -1 || currentCol - 1 == -1 || matrix[currentRow - 1, currentCol - 1] != matrix[currentRow, currentCol])
                        {
                            break;
                        }
                        else
                        {
                            currentRow++;
                            currentCol--;
                        }
                    }

                    if (currentScore > bestScore)
                    {
                        bestScore = currentScore;
                        bestSequence = currentSequence;

                        currentScore = 1;
                        currentSequence = matrix[row, col];
                    }

                }


            }
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Best Sequence: {0}", bestScore);

        return bestSequence;
    }

    static void Print(string sequence)
    {
        Console.WriteLine("({0})", sequence);
    }
    static void Main()
    {
        int m = 4; //row
        int n = 5; //col
        string[,] matrix = 
        {
            {"ha", "fu", "ba", "fu", "ba"},
            {"fu", "ha", "fu", "fu", "hi"},
            {"ba", "fu", "hi", "hi", "ba"},
            {"fu", "hi", "ba", "ha", "hi"}
        };

        Print(FindBestSequence(matrix, m, n));

    }
}

