using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArr[i] = ReadArrayFromConsole();
            }

            string command = Console.ReadLine()?.ToUpper();

            while (command != "END")
            {
                string[] token = command.Split();

                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                int value = int.Parse(token[3]);

                if (row < 0 || row >= n || col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine()?.ToUpper();
                    continue;
                }

                switch (token[0])
                {
                    case "ADD":
                        jaggedArr[row][col] += value;
                        break;
                    case "SUBTRACT":
                        jaggedArr[row][col] -= value;
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine()?.ToUpper();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(' ', jaggedArr[i]));
            }
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

    }
}
