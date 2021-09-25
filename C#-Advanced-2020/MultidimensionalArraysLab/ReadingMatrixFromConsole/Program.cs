using System;
using System.Linq;

namespace ReadingMatrixFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] colElements = ReadArrayFromConsole();

                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
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
