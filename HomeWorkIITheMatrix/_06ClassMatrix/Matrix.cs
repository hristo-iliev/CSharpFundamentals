using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ClassMatrix
{
    class Matrix
    {
        

        private int[,] matrix;

        public Matrix(int rows, int colums) //конструктор. не връща параметри!!!! носи името на класа!!!!
        {
            this.matrix = new int[rows, colums];

        }


        public int getRows()
        {
            return this.matrix.GetLength(0);
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
                        
        }
        public int Colums
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }
        

        public int this[int row, int col]  //indexator
        {
            get
            {
                
                return this.matrix[row, col];
                
            }
            set
            {
                this.matrix[row, col] = value;
                
            }
        }

        

        public static Matrix  operator + (Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Colums);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Colums; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }

            return result;

        }

        public static Matrix  operator - (Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Colums);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Colums; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator * (Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Colums);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Colums; col++)
                {
                    result[row, col] = first[row, col] * second[row, col];
                }
            }
            return result;
        }

        public override string ToString()
        {
            string result = null;

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Colums; col++)
                {
                    result += (matrix[row, col] + " ");
                }
                result += Environment.NewLine;
            }

            return result;
        }
       
    }
}
