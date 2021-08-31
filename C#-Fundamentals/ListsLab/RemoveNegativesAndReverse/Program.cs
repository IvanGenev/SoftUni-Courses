using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shorter version:

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x >= 0)
                .Reverse()
                .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            //// Another version:

            //List<int> numbers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //List<int> result = new List<int>();

            //for (int i = numbers.Count - 1; i >= 0; i--)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        result.Add(numbers[i]);
            //    }
            //}

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}

            //Console.WriteLine(string.Join(" ", result));

            //List<int> integers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //List<int> result = new List<int>();

            //foreach (var element in integers)
            //{
            //    if (element > 0)
            //    {
            //        result.Add(element);
            //    }
            //}

            //result.Reverse();

            //if (result.Count == 0)
            //{
            //    Console.WriteLine("empty");
            //}

            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
