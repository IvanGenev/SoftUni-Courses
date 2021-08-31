using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulatingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Manipulating collections: .Select() manipulates elements in a collection:
            //var nums = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse);
            //// or
            //string[] words = { "abc", "def" };
            //var result = words.Select(w => w + "x");

            //// Converting Collections: .ToArray(), .ToList() to convert colletctions:
            //int[] nums = Console.ReadLine()
            //    .Split()
            //    .Select(n => int.Parse(n))
            //    .ToArray();
            //// or
            //List<double> num = Console.ReadLine()
            //    .Split()
            //    .Select(double.Parse)
            //    .ToList();

            //// Filtering collections: .Where():
            //int[] nums = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .Where(n => n > 0)
            //    .ToArray();

            //// Sorting collections: .OrderBy() and .OrderByDescending():
            //List<int> nums = new() { 1, 5, 4, 2, 6 };
            //nums = nums.OrderBy(n => n).ToList();
            //Console.WriteLine(string.Join(", ", nums));

            //// or
            //List<int> num = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //num = num.OrderByDescending(n => n).ToList();
            //Console.WriteLine(string.Join(", ", num));

            //// Sorting collections by Multiple criteria: .ThenBy():
            //var products = new Dictionary<int, string>();
            //Dictionary<int, string> sortedDict = products
            //    .OrderBy(pair => pair.Value)
            //    .ThenBy(pair => pair.Key)
            //    .ToDictionary(pair => pair.Key, pair => pair.Value);
        }
    }
}
