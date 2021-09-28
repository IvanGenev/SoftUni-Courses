using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeSquare = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeSquare, sizeSquare];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = ReadArrayFromConsole();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];

                }
            }

            int diagSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        diagSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(diagSum);
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
