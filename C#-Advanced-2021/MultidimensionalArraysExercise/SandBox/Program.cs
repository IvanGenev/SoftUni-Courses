using System;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[row] = new int[input.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = input[col];
                }
            }

            int currentRow = 0;
            int currentCol = 0;

            int nextRow = 0;
            int nextCol = 0;

            string direction = Console.ReadLine();

            switch (direction)
            {
                case "up":
                    nextRow--;
                    break;
                case "down":
                    nextRow++;
                    break;
                case "left":
                    nextCol--;
                    break;
                case "right":
                    nextCol++;
                    break;
                default:
                    break;
            }

            if (!IsInside(jaggedArray, currentRow + nextRow, currentCol + nextCol))
            {
                Console.WriteLine("Outside");
            }

            currentRow += nextRow;
            currentCol += nextCol;

            //Environment.Exit(0); // if we need to exit current
        }

        private static bool IsInside(int[][] jaggedArray, int row, int col)
        {
            return row >= 0 && row < jaggedArray.Length &&
                col >= 0 && col < jaggedArray[row].Length;
        }
    }
}
