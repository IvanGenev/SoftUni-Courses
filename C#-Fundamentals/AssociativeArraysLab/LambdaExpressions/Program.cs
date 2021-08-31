using System;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // a => a < 5
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] smaller = array.Where(x => x > 5).ToArray();

            Console.WriteLine(string.Join(" ", smaller));
        }

        // x => x < 5;
        static bool IsSmallerThanFive(int x)
        {
            return x < 5;
        }
    }
}
