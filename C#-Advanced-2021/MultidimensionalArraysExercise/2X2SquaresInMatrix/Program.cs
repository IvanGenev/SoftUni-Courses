using System;
using System.Linq;

namespace _2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = ReadArrayFromConsole();

            int matrixRows = matrixSize[0];
            int matrixCols = matrixSize[1];

            char[,] matrix = new char[matrixRows, matrixCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] matrixChar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixChar[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && 
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
