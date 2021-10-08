using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(matrixSizes[0]);
            int cols = int.Parse(matrixSizes[1]);

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (commandInput[0] != "END")
            {
                if (commandInput[0].ToUpper() == "SWAP" && commandInput.Length == 5)
                {
                    int row1 = int.Parse(commandInput[1]);
                    int col1 = int.Parse(commandInput[2]);
                    int row2 = int.Parse(commandInput[3]);
                    int col2 = int.Parse(commandInput[4]);

                    if (row1 >= 0 && row1 <= rows - 1 && col1 >= 0 && col1 <= cols - 1
                        && row2 >= 0 && row2 <= rows - 1 && col2 >= 0 && col2 <= cols - 1)
                    {
                        string newElement = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = newElement;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]}" + " ");
                            }

                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
