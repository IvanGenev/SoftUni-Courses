using System;
using System.Linq;

namespace SquareMaxSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2:06


        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
