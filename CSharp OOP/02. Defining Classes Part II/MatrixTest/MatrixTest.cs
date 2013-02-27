using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix8910
{
    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> mtrx1 = new Matrix<int>(3, 2);
            Matrix<int> mtrx2 = new Matrix<int>(2, 2);
            Matrix<float> mtrx3 = new Matrix<float>(2, 2);

            mtrx1[0, 0] = 1;
            mtrx1[0, 1] = 3;
            mtrx1[1, 0] = 0;
            mtrx1[1, 1] = -2;
            mtrx1[2, 0] = 4;
            mtrx1[2, 1] = 1;
            
            mtrx2[0, 0] = 7;
            mtrx2[0, 1] = 9;
            mtrx2[1, 0] = 5;
            mtrx2[1, 1] = 2;

            //Console.WriteLine(mtrx1[1,1] + mtrx2[1,1]);

            //mtrx1 = mtrx1 * mtrx2;

            for (int i = 0; i < mtrx1.Rows; i++)
            {
                for (int k = 0; k < mtrx1.Cols; k++)
                {
                    Console.Write(mtrx1[i, k] + " ");
                }
                Console.WriteLine();
            }

            if (mtrx1)
            {
                Console.WriteLine(mtrx1);
            }
            //Console.WriteLine(mtrx2.CheckNonZeroElements());
            //Console.WriteLine(mtrx3.CheckNonZeroElements());

        }
    }
}
