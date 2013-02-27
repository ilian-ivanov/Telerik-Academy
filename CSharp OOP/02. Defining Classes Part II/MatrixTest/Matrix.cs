using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix8910
{
    public class Matrix<T> 
        where T : struct, IComparable
    {
        private T[,] mtrx;
        private int rows, cols;

        // CONSTRUCTORS -----------------------------------------
        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.mtrx = new T[rows, cols];
        }

        //  PROPERTIES ----------------------------------------------------------------
        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }
        
        public T this[int row, int col]
        {
            get
            {
                if (row < this.rows && row >= 0
                    && col < this.cols && col >= 0)
                {
                    return this.mtrx[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (row < this.rows && row >= 0
                   && col < this.cols && col >= 0)
                {
                    this.mtrx[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        // METHODS -----------------------------------------------------------------
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> newMatrix = new Matrix<T>(first.Rows, first.Cols);

                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        newMatrix[i, j] = first[i, j] + (dynamic)second[i, j];
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new ArgumentException("The matricies are not with the same rows and cols!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> newMatrix = new Matrix<T>(first.Rows, first.Cols);

                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        newMatrix[i, j] = first[i, j] - (dynamic)second.mtrx[i, j];
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new ArgumentException("The matricies are not with the same rows and cols!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols == second.Rows)
            {
                Matrix<T> newMatrix = new Matrix<T>(first.Rows, first.Cols);

                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        for (int k = 0; k < first.Cols; k++)
                        {
                            newMatrix[i, j] += first[i, k] * (dynamic)second[k, j];
                            // if you want to see multiply by steps uncomment next 3 rows
                            // Console.Write(" " + newMatrix[i, j] + "= " + first[i,k] + "*" + second[k,j]);
                        }
                        // Console.WriteLine();
                    }
                    // Console.WriteLine();
                }
                return newMatrix;
            }
            else
            {
                throw new ArgumentException("The two matricies can't be multiply!");
            }
        }

        public static bool operator true(Matrix<T> mtrx)
        {
            for (int i = 0; i < mtrx.Rows; i++)
            {
                for (int k = 0; k < mtrx.Cols; k++)
                {
                    if (mtrx[i, k].CompareTo(Convert.ChangeType(0, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> mtrx)
        {
            for (int i = 0; i < mtrx.Rows; i++)
            {
                for (int k = 0; k < mtrx.Cols; k++)
                {
                    if (mtrx[i, k].CompareTo(Convert.ChangeType(0, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
