using System;
using System.Linq;

namespace DiagonalDifference2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputIntegers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputIntegers[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primaryDiagonal += matrix[row, row];
            }

            int counter = matrix.GetLength(0) - 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secondaryDiagonal += matrix[row, counter];
                counter--;
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
