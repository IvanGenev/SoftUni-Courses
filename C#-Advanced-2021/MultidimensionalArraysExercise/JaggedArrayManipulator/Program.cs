using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string command = Console.ReadLine()?.ToUpper();

            while (command != "END")
            {
                string[] commandArgs = command.Split();

                string action = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                if (!(row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length))
                {
                    command = Console.ReadLine()?.ToUpper();
                    continue;
                }

                if (action == "ADD")
                {
                    jaggedArray[row][col] += value;
                }
                else if (action == "SUBTRACT")
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine()?.ToUpper();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}
