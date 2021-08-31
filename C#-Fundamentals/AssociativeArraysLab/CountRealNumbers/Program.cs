using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //var numbersArray = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //SortedDictionary<double, int> numbersDictionary = new();
            var counts = new SortedDictionary<double, int>();

            //for (int i = 0; i < numbersArray.Length; i++)
            //{
            //    if (!numbersDictionary.ContainsKey(numbersArray[i]))
            //    {
            //        numbersDictionary.Add(numbersArray[i], 0);
            //    }

            //    numbersDictionary[numbersArray[i]]++;
            //}
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            //foreach (var item in numbersDictionary)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}
            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
