using System;

namespace PrintingTriangle
{
    class Program
    {
        // First create a method that prints a single line, consisting of numbers from a given start to a given end:

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
                Console.Write(i + " ");

            Console.WriteLine();
        }

        // Then create another method that prints the first half (1..n) and then the second half (n-1..1) of the triangle:

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        // Then read the input:

        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }
    }
}
