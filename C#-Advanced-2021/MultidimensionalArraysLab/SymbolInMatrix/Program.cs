using System;
using System.Linq;
using System.Text;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                string colElement = Console.ReadLine();

                for (int col = 0; col < colElement.Length; col++)
                {
                    matrix[row, col] = colElement[col];
                }
            }

            string symbolInput = Console.ReadLine();

            bool isFound = false;

            int symbolCheck = 0;

            foreach (var item in symbolInput)
            {
                symbolCheck = (int)item;
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == symbolCheck)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{(char)symbolCheck} does not occur in the matrix");
            }
        }
    }
}
