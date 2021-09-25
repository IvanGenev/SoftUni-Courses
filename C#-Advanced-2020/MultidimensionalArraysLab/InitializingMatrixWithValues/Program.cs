using System;

namespace InitializingMatrixWithValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {2,3,4 },
                {4,6,7 },
                {3,4,5 }
            };

            // Foreach iterates through all elements in the matrix:

            //foreach (int element in matrix)
            //{
            //    Console.WriteLine(element);
            //}

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
