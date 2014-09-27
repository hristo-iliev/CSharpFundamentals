using System;

class PrintingMatrix
{
    // Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

    static int[,] FillA(int n)
    {
        int[,] matrix = new int[n, n];

        

        for (int row = 0; row < n; row++)
        {
            int value = row + 1;
            for (int col = 0; col < n; col++)
            {
                if (col == 0)
                {
                    value += col;
                    matrix[row, col] = value;
                    
                }
                else
                {
                    value += n;
                    matrix[row, col] = value;
                    
                }
            }
        }

        return matrix;
    }

    static int[,] FillB(int n)
    {
        int[,] matrix = new int[n, n];

        string direction = "down";
        int value = 1;
        int row = 0;
        int col = 0;

        while (true)
        {
            if (value == (n*n) + 1)
            {
                break;
            }

            matrix[row, col] = value;
            value++;

            if (direction == "down")
            {
                
                if (row + 1 == n)
                {
                    
                    direction = "up";
                    col++;
                }
                else
                {
                    
                    
                    row++;
                }

            }
            else if (direction == "up")
            {
                
                if (row - 1 < 0)
                {
                    direction = "down";
                    col++;
                }
                else
                {
                    
                    
                    row--;
                }
            }
        }

        return matrix;
    }

    static int[,] FillC(int n)
    {
        int[,] matrix = new int[n, n];

        int value = 1;
        int row = n-1;
        int col = 0;

        while (true)
        {
            if (value == n*n+1)
            {
                break;
            }

            matrix[row, col] = value;
            row++;
            col++;
            value++;

            if (row == n || col ==n)
            {
                row--;

                if (col  == n)
                {
                    row--;
                    col--;
                }
                while (row - 1 >= 0 && col -1 >= 0)
                {
                    row--;
                    col--;
                }
            }


        }

        return matrix;
    }

    static int[,] FillD(int n)
    {
        int[,] matrix = new int[n, n];

        int row = 0;
        int col = 0;
        int value = 1;

        string direction = "down";

        while (true)
        {
            if (value == n*n + 1)
            {
                break;
            }

            matrix[row, col] = value;
            value++;


            if (direction == "down")
            {
                if (row+1 == n || matrix[row+1,col] != 0)
                {
                    direction = "right";
                    col++;
                }
                else
                {
                    row++;
                }
            }
            else if (direction == "right")
            {
                if (col+1 == n || matrix[row, col+1] != 0)
                {
                    direction = "up";
                    row--;
                }
                else
                {
                    col++;
                }
            }
            else if (direction == "up")
            {
                if (row - 1 < 0 || matrix[row-1,col] != 0)
                {
                    direction = "left";
                    col--;
                }
                else
                {
                    row--;
                }
            }
            else if (direction == "left")
            {
                if (matrix[row,col-1] != 0)
                {
                    direction = "down";
                    row++;
                }
                else
                {
                    col--;
                }
            }
        }
        
        return matrix;
    }

    static void Print(int[,] matrix)
    {
        string space = "";
        string countOfDigits = matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1].ToString();
        
        for (int i = 0; i <  countOfDigits.Length; i++)
		{
			 space += " ";
		}

        

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3}{1}",matrix[row,col], space);
                
                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(new string('~', 70));
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int n = 3;

        Print(FillA(n));
        Print(FillB(n));
        Print(FillC(n));
        Print(FillD(n));
    }
}

