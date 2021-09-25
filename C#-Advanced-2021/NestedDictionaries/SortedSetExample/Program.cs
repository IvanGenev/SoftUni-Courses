using System;
using System.Collections.Generic;

namespace SortedSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The elements are ordered incrementally

            SortedSet<string> names = new SortedSet<string>();

            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Pesho");
            names.Add("Gosho");
            names.Add("Maria");
            names.Add("Anelia");

            Console.WriteLine(string.Join(", ", names));

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
