
//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4) - D)

using System;

class FillsAndPrintsMatrixD
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrixD= new int[n, n];
        int row = 0, col = 0;
        int count = 1;
        int firstStopper = 0;
        int secondStopper = 2;


        for (int k = 0; k < n; k++)
        {

            // top to bottom
            for (row = firstStopper; row < n - firstStopper; row++)
            {
                matrixD[row, col] = count;
                count++;
            }

            // right to left
            row--;
            for (col = firstStopper + 1; col < n - firstStopper; col++)
            {
                matrixD[row, col] = count;
                count++;
            }

            // bottom to top
            col--;
            for (row = n - secondStopper; row >= firstStopper; row--)
            {
                matrixD[row, col] = count;
                count++;
            }

            // left to right
            row++;
            for (col = n - secondStopper ; col > firstStopper; col--)
            {
                matrixD[row, col] = count;
                count++;
            }

            col++;
            firstStopper++;
            secondStopper++;
        }


        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0, 4}", matrixD[r, c]);
            }
            Console.WriteLine();
        }

    }
}

