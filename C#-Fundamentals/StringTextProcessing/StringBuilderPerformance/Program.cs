using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a StringBuilder from the Console:
            // Best way: StringBuilder builder = new StringBuilder(Console.ReadLine());

            // Second way:
            // string input = Console.ReadLine();
            // StringBuilder text = new StringBuilder(input);

            // or
            // text.Append(input);

            
            int count = 40000;
            Console.WriteLine("Test concatenation: ");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string textFirst = string.Empty;

            for (int i = 0; i < count; i++)
            {
                textFirst += i;
            }

            watch.Stop();
            Console.WriteLine($"String concatenation: {watch.ElapsedMilliseconds} milliseconds");
            watch.Reset();

            watch.Start();
            StringBuilder textSecond = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                textSecond.Append(i);
            }

            watch.Stop();
            Console.WriteLine($"StringBuilder concatenation: {watch.ElapsedMilliseconds} milliseconds");
            watch.Reset();

            Console.WriteLine("Test insert: ");
            watch = new Stopwatch();
            watch.Start();
            textFirst = string.Empty;

            for (int i = 0; i < count; i++)
            {
                int start = textFirst.Length - 10 >= 0 ? textFirst.Length - 10 : 0;
                textFirst = textFirst.Insert(start, i.ToString());
            }

            watch.Stop();
            Console.WriteLine($"String insert: {watch.ElapsedMilliseconds} milliseconds");
            watch.Reset();

            watch.Start();
            textSecond = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                int start = textSecond.Length - 10 >= 0 ? textSecond.Length - 10 : 0;
                textSecond.Insert(start, i.ToString());
            }

            watch.Stop();
            Console.WriteLine($"StringBuilder insert: {watch.ElapsedMilliseconds} milliseconds");
            watch.Reset();
        }
    }
}
