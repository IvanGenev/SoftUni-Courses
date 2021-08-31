using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new() { 1, 4, 5, 2, 7, 8, 3, 9 };

            //list = list.Where((n, index) => n % 2 == 0).ToList();

            //Console.WriteLine(string.Join(", ", list));

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Sum());

            string[] words = { "abc", "def", "ghi" };
            var result = words.Select(w => w + "x");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
