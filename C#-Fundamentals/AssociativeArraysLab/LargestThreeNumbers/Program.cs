﻿using System;
using System.Linq;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
