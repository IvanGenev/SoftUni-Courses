using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;

                for (int leftNum = i; leftNum > 0; leftNum--)
                {
                    int nextNum = leftNum - 1;
                    
                    if (leftNum > 0)
                    {
                        leftSum += input[nextNum];
                    }
                }

                rightSum = 0;

                for (int rightNum = i; rightNum < input.Length; rightNum++)
                {
                    int nextNum = (rightNum + 1);
                    if (rightNum < input.Length - 1)
                    {
                        rightSum += input[nextNum];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
