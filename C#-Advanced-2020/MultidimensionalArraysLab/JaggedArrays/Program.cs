using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filling a Jagged Array
            int[][] jaggedArray = new int[5][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split();

                jaggedArray[row] = new int[inputNumbers.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = int.Parse(inputNumbers[col]);
                }
            }


            // Printing a Jagged Array with For-loop:
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write("{0}", jaggedArray[row][col]);
                }
            }
            Console.WriteLine();

            // Printing a Jagged Array with Foreach loop:

            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
