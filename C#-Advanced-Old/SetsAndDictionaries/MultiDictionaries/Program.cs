using System;
using System.Collections.Generic;

namespace MultiDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

            grades["Peter"] = new List<int>();
            grades["Peter"].Add(5);
            grades["Kevin"] = new List<int>() { 6, 6, 3, 4, 6 };

            Console.WriteLine(string.Join(" ", grades["Kevin"]));
        }
    }
}
