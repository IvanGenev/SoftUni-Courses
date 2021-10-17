using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primaryDiagonal += matrix[row, col];
                    }
                }
            }


            for (int row = 0; row < matrix.GetLength(0);)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    secondaryDiagonal += matrix[row, col];

                    int nextRow = row++;
                }

                break;
            }

            // Another solution for calculating the secondaryDiagonal:

            //for (int row = 0, col = size - 1 ; row < size; row++, col--)
            //{
            //    secondaryDiagonal += matrix[row, col];
            //}

            int diagonalDifference = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(diagonalDifference);
        }
    }
}
