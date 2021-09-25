using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numOfQueries; i++)
            {
                int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (queries[0] == 1)
                {
                    numbers.Push(queries[1]);
                }
                else if (queries[0] == 2 && numbers.Count > 0)
                {
                    numbers.Pop();
                }
                else if (queries[0] == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (queries[0] == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
