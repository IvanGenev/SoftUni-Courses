using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Another solution with method:

            List<int> first = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            if (first.Count > second.Count)
            {
                result.AddRange(GetRemainingElements(first, second));
            }
            else if (second.Count > first.Count)
            {
                result.AddRange(GetRemainingElements(second, first));
            }

            Console.WriteLine(string.Join(" ", result));

        static IEnumerable<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
                List<int> nums = new List<int>();
                for (int i = shorterList.Count; i < longerList.Count; i++)
                {
                    nums.Add(longerList[i]);
                }

                return nums;
        }
            //List<int> firstCollection = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //List<int> secondCollection = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //List<int> result = new List<int>();

            //int maxCount = Math.Max(firstCollection.Count, secondCollection.Count);

            //for (int i = 0; i < maxCount; i++)
            //{
            //    if (i < firstCollection.Count)
            //    {
            //        result.Add(firstCollection[i]);
            //    }

            //    if (i< secondCollection.Count)
            //    {
            //        result.Add(secondCollection[i]);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", result));
        }

    }
}
