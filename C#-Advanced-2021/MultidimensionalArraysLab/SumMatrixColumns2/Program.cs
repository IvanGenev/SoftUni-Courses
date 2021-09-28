using System;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            // First version of calculating:
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var colSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    colSum += matrix[row, col];
                }

                Console.WriteLine(colSum);
            }


            // Second version of calculating:

            int[] colSums = new int[matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    colSums[col] += matrix[row, col];
                }
            }

            for (int i = 0; i < colSums.Length; i++)
            {
                Console.WriteLine(colSums[i]);
            }

        }
    }
}
