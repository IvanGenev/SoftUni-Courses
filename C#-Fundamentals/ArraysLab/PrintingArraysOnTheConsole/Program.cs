using System;

namespace PrintingArraysOnTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing arrays on the console
            string[] arr = { "one", "two" }; // == new string[2] {"one", "two"};
            // Process all array elements
            for (int index = 0; index < arr.Length; index++)
            {
                // Pring each element on a separate line
                Console.WriteLine("arr[{0}] = {1}", index, arr[index]);
            }

            // Use string.Join(separator, array):
            int[] arr1 = { 1, 2, 3 };
            Console.WriteLine(string.Join(", ", arr1));
            string[] strings = { "one", "two" };
            Console.WriteLine(string.Join(" - ", strings));

            // Pring Array with foreach:

            int[] numbers = { 1, 2, 3, 4, 5, };
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
