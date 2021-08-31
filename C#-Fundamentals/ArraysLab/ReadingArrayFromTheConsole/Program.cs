using System;
using System.Linq;

namespace ReadingArrayFromTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, read from the console thearray length:
            int n = int.Parse(Console.ReadLine());
            // Next, create an array with the n-length and read its elements:
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Reading Array Values from a single line
            string values = Console.ReadLine();
            string[] items1 = values.Split();
            int[] arr1 = new int[items1.Length];

            for (int i = 0; i < items1.Length; i++)
            {
                arr1[i] = int.Parse(items1[i]);
            }

            // Shorter reading an array from a single line:
            var inputLine = Console.ReadLine();
            string[] items2 = inputLine.Split(',');
            int[] arr2 = items2.Select(int.Parse).ToArray();

            // The shortest:
            int[] arr3 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        }
    }
}
