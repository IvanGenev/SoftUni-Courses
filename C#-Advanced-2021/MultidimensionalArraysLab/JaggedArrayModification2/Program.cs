using System;
using System.Linq;

namespace JaggedArrayModification2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] arrays = new int[n][];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(" ");

                arrays[i] = new int[lineParts.Length];

                for (int j = 0; j < lineParts.Length; j++)
                {
                    arrays[i][j] = int.Parse(lineParts[j]);
                }
            }

            while (true)
            {
                string line = Console.ReadLine().ToUpper();
                string[] commandParts = line.Split(" ");
                string commandName = commandParts[0];

                if (commandName == "END")
                {
                    break;
                }

                int arrayIndex = int.Parse(commandParts[1]);
                int arrayElement = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (arrayIndex < 0 || arrayIndex >= arrays.Length || arrayElement < 0 || arrayElement >= arrays[arrayIndex].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                
                if (commandName == "ADD")
                {
                    arrays[arrayIndex][arrayElement] += value;
                }
                else if (commandName == "SUBTRACT")
                {
                    arrays[arrayIndex][arrayElement] -= value;
                }
            }

            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(string.Join(", ", arrays[i]));
            }
        }
    }
}
