using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxArrays
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int leftNumber = 0; leftNumber < input.Length; leftNumber++)
            {
                bool isTopInteger = true;

                for (int rightNumber = leftNumber + 1; rightNumber < input.Length; rightNumber++)
                {
                    if (input[leftNumber] <= input[rightNumber])
                    {
                        isTopInteger = false;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(string.Join(" ", input[leftNumber]) + " ");
                }
            }
        }
    }
}
