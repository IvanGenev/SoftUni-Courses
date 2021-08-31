using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DictionaryPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new();
            List<int> list = new();

            int n = 300000;

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, i);
                list.Add(i);
            }


            Stopwatch timer = new();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                list.Contains(i);
            }
            timer.Stop();
            Console.WriteLine($"Contains with list: " + timer.ElapsedMilliseconds);

            timer.Reset();
            timer.Start();

            for (int i = 0; i < n; i++)
            {
                dictionary.ContainsKey(i);
            }

            timer.Stop();
            Console.WriteLine($"Contains with dictionary: " + timer.ElapsedMilliseconds);
        }
    }
}
