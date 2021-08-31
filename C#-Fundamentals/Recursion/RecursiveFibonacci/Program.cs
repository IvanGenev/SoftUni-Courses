using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            long result = Fib(n);
            Console.WriteLine("fib({0}) = {1}", n, result);
        }

        // Very inefficient recursive calculation!
        private static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
