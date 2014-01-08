using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTest
    {
        static void Main(string[] args)
        {
            Matrix<int> myMatrix = new Matrix<int>( 2, 2 );
            Matrix<int> anotherMatrix = new Matrix<int>( 2, 2 );

            int counter = 0;

            for( int i = 0; i < myMatrix.Rows; i++ )
            {
                for( int k = 0; k < myMatrix.Cols; k++ )
                {
                    anotherMatrix[i,k] = counter;
                    myMatrix[i, k] = counter;
                    counter++;
                }
            }

            /*
                        Matrix<string> myMatrix = new Matrix<string>( 2, 2 );

                        int counter = 0;

                        for( int i = 0; i < myMatrix.Rows; i++ )
                        {
                            for( int k = 0; k < myMatrix.Cols; k++ )
                            {
                                myMatrix[i, k] = counter.ToString();
                                counter++;
                            }
                        }
            */

            Console.WriteLine(myMatrix[1,1]);

          /*  int [,] matrixM = new int [4,5];
            for( int i = 0; i < matrixM.GetLength(0); i++ )
            {
                for( int k = 0; k < matrixM.GetLength(1); k++ )
                {
                    matrixM[i, k] = counter;
                    counter++;
                }
            }*/


            Matrix<int> someMatrix = myMatrix + anotherMatrix;

            Matrix<int> mat = someMatrix - myMatrix;

            Matrix<int> m1 = new Matrix<int>( 4, 3 );
            Matrix<int> m2 = new Matrix<int>( 3, 2 );

            m1[0, 0] =1; 
            m1[0, 1] =-1; 
            m1[0, 2] = 0;

            m1[1, 0] =0; 
            m1[1, 1] =2; 
            m1[1, 2] =3; 

            m1[2, 0] =1 ;
            m1[2, 1] = -3;
            m1[2, 2] =1;

            m1[3, 0] = 4;
            m1[3, 1] = 0;
            m1[3, 2] = 2;


            m2[0, 0] = 2;
            m2[0, 1] = 1;

            m2[1, 0] = -1;
            m2[1, 1] = 0;

            m2[2, 0] = 3;
            m2[2, 1] = 1;


            Matrix<int> proizv = m1 * m2;

            for( int i = 0; i < proizv.Rows; i++ )
            {
                for( int j = 0; j < proizv.Cols; j++ )
                {
                    Console.Write(" {0} ", proizv[i,j]);
                }
                Console.WriteLine( );
            }

        }

    }
}
