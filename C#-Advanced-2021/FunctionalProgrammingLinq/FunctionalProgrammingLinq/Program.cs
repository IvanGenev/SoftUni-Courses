using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(1, 2, Multiply);

            var list = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var newList = list.Where(x => x % 2 != 0);

            Console.WriteLine(string.Join(", ", newList));

            var numbers = Enumerable.Range(1, 100);

            var num = numbers.Aggregate(0, (sum, x) => sum + x);
            Console.WriteLine(num);

            var groupsByTenth = numbers.GroupBy(x => x % 10); // group by 10th
            var groupsByLength = numbers.GroupBy(x => x.ToString().Length); // group by length of digits

            foreach (var group in groupsByTenth)
            {
                Console.WriteLine(group.Key + " " + group.Sum());
            }

        }

        static bool EvenNumbers(int x) => x % 2 == 0;
        

        static void PrintResult(int a, int b, Func<int, int, long> func)
        {
            for (int i = 0; i < 5; i++)
            {
                var result = func(a + 1, b + 1);
                Console.WriteLine(new string('=', 50));
                Console.WriteLine($"Result: {result}");
                Console.WriteLine(new string('=', 50));
            }
        }

        static string Greetings()
        {
            return "Hello!";
        }

        static long Multiply(int a, int b)
        {
            return a * b;
        }

        static long Sum(int a, int b)
        {
            return a + b;
        }
    }
}
