using System;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static int[] Sort(params int[] numbers)
        {
            // The sorting logic comes here...

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop operating over the unsorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;
                    }
                }
            } // End of the sorting logic
            return numbers;
        }

        static void PrintNumbers(params int[] numbers) =>
            Console.WriteLine($"[{String.Join(", ", numbers)}]");

        static void Main()
        {
            int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
            PrintNumbers(numbers);
        }
    }
}
