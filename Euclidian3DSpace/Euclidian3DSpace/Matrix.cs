////TASK 8
////Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

////TASK 9
////Implement an indexer this[row, col] to access the inner matrix cells.

////TASK 10
////Implement the operators + and - (addition and subtraction of matrices of the same size)
////and * for matrix multiplication. Throw an exception when the operation cannot be performed.
////Implement the true operator (check for non-zero elements).

namespace Euclidian3DSpace
{
    using System;

    [Version(2.1)]
    public class Matrix<T> where T : struct, IComparable 
    {        
        private T[,] numbers;
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.numbers = new T[this.row = row, this.col = col];
        }

        public int Row
        {
            get
            {
                return this.row;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.numbers[row, col];
            }

            set
            {
                this.numbers[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row != second.Row || first.Col != second.Col)
            {
                throw new ArgumentException("The matrices are with different size");
            }

            Matrix<T> result = new Matrix<T>(first.Row, first.Col);

            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = (dynamic)first[i, j] + second[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row != second.Row || first.Col != second.Col)
            {
                throw new ArgumentException("The matrices are with different size");
            }

            Matrix<T> result = new Matrix<T>(first.Row, first.Col);

            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = (dynamic)first[i, j] - second[i, j];  
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col != second.Row || (first.Row < 0 || second.Col < 0 || first.Col < 0))
            {
                throw new ArgumentException("Multiplication can't be done");
            }

            Matrix<T> result = new Matrix<T>(first.Row, second.Col);
            for (int i = 0; i < result.Row; i++)
            {
                for (int j = 0; j < result.Col; j++)
                {
                    result[i, j] = (dynamic)0;
                    for (int k = 0; k < first.Col; k++)
                    {
                        result[i, j] = result[i, j] + ((dynamic)first[i, k] * second[k, j]);
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> current)
        {
            for (int i = 0; i < current.Row; i++)
            {
                for (int j = 0; j < current.Col; j++)
                {
                    if (current[i, j] != (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> current)
        {            
            for (int i = 0; i < current.Row; i++)
            {
                for (int j = 0; j < current.Col; j++)
                {
                    if (current[i, j] != (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
