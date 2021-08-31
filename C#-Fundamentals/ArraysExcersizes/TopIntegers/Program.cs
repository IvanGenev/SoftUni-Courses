using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            for (int leftNum = 0; leftNum < input.Length; leftNum++)
            {
                bool isTopInteger = true;

                for (int rightNum = leftNum + 1; rightNum < input.Length; rightNum++)
                {
                    if (input[leftNum] <= input[rightNum])
                    {
                        isTopInteger = false;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(input[leftNum] + " ");
                }
            }
        }
    }
}
