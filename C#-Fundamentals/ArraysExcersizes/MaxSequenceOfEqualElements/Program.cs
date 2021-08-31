using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int equalElements = 1;
            int maxSequence = 0;
            int currentElement = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    equalElements++;
                }
                else
                {
                    equalElements = 1;
                }

                if (equalElements > maxSequence)
                {
                    maxSequence = equalElements;
                    currentElement = input[i];
                }
            }

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(currentElement + " ");
            }
        }
    }
}
