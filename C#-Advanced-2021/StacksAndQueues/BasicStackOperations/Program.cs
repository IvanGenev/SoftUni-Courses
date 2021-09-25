using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operationNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            int n = operationNumbers[0];
            int s = operationNumbers[1];
            int x = operationNumbers[2];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (n > 0)
                {
                    numbers.Push(inputNumbers[i]);
                    n--;
                }
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
