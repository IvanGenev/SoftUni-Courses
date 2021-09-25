using System;
using System.Linq;

namespace SquareMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = ReadArrayFromConsole();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }

            int maxSum = int.MinValue;
            int matrixRow = 0;
            int matrixCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sumMiniMatrix = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sumMiniMatrix > maxSum)
                    {
                        maxSum = sumMiniMatrix;

                        matrixRow = row;
                        matrixCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[matrixRow, matrixCol]} {matrix[matrixRow, matrixCol + 1]}");
            Console.WriteLine($"{matrix[matrixRow + 1, matrixCol]} {matrix[matrixRow + 1, matrixCol + 1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
