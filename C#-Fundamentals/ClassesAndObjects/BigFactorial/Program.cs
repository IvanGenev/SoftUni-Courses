using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FactorialCalc calculator = new FactorialCalc(n);

            Console.WriteLine(calculator.Calculate());
        }
    }
}
