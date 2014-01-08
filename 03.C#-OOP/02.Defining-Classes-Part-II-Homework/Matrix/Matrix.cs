using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> where T: IComparable<T>
    {
        private T[,] matrix;//Field

        public Matrix(int rows,int cols)//Constructor
        {
            matrix = new T[rows,cols];
        }

        public int Rows  //Get the rows
        {
            get
            {
                return this.matrix.GetLength( 0 );
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength( 1 );
            }
        }

        public T this [ int row, int col]
        {
            get
            {
                if( row < 0 || row >= Rows || col < 0 || col >= Cols )
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if( row < 0 || row >= Rows || col < 0 || col >= Cols )
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    matrix[row, col] = value;
                }
            }

        }

        public static Matrix<T> operator + (Matrix<T>firstMatrix,Matrix<T> secondMatrix)
        {
            Matrix<T> newMatrix= new Matrix<T>(firstMatrix.Rows,firstMatrix.Cols);

            if( (firstMatrix.Rows != secondMatrix.Rows) || (firstMatrix.Cols != secondMatrix.Cols) )
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for( int i = 0; i < firstMatrix.Rows; i++ )
                {
                    for( int k = 0; k < firstMatrix.Cols; k++ )
                    {
                        newMatrix[i, k] = (dynamic)firstMatrix[i, k] + (dynamic)secondMatrix[i, k];
                    }
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> newMatrix = new Matrix<T>( firstMatrix.Rows, firstMatrix.Cols );

            if( (firstMatrix.Rows != secondMatrix.Rows) || (firstMatrix.Cols != secondMatrix.Cols) )
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for( int i = 0; i < firstMatrix.Rows; i++ )
                {
                    for( int k = 0; k < firstMatrix.Cols; k++ )
                    {
                        newMatrix[i, k] = (dynamic)firstMatrix[i, k] - (dynamic)secondMatrix[i, k];
                    }
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> newMatrix = new Matrix<T>( firstMatrix.Rows, secondMatrix.Cols );

            int myltiplication = 0;

            if( (firstMatrix.Cols != secondMatrix.Rows) )
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for( int i = 0; i < newMatrix.Rows; i++ )
                {
                    for( int j = 0; j < newMatrix.Cols; j++ )
                    {
                        for( int k = 0; k < firstMatrix.Cols; k ++ )
                        {
                            myltiplication = (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];

                            newMatrix[i, j] = newMatrix[i, j] + (dynamic)myltiplication;
                        }
                    }
                }
            }
            return newMatrix;
        }

    }
}
