using System;

namespace JaggedArraysIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filling a jagged array:

            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] numbersAsString = line.Split();
                arr[i] = new int[numbersAsString.Length];

                for (int j = 0; j < numbersAsString.Length; j++)
                {
                    arr[i][j] = int.Parse(numbersAsString[j]);
                }
            }

            // Reading from the jagged array:

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j] + ", ");
                }

                Console.WriteLine();
            }
        }
    }
}
