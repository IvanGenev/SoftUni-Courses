using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operationNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            int n = operationNumbers[0];
            int s = operationNumbers[1];
            int x = operationNumbers[2];

            for (int i = 0; i < numbersInput.Length; i++)
            {
                if (n > 0)
                {
                    numbers.Enqueue(numbersInput[i]);
                    n--;
                }
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
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
