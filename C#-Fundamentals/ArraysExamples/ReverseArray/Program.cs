using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //var result = nums.Reverse().ToArray();

            //Console.WriteLine(string.Join(", ", result));

            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));
        }
    }
}
