using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main()
        {
            List<string> numbersAsStrings = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<int> numbers = new();

            foreach (var item in numbersAsStrings)
            {
                numbers.AddRange(item.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList()
                    );
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
