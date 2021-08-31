using System;

namespace RecursionExamples
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //Factorial method
        static decimal Factorial(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the mothod calls itself
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //// Fibonachi numbers

        //static long Fib(int n)
        //{
        //    if (n <= 2)
        //    {
        //        return 1;
        //    }
        //    return Fib(n - 1) + Fib(n - 2);
        //}
    }
}
