using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var number in numbers)
            {
                double result = Math.Round(number, 0, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{number} => {result}");
            }

            double[] reversed = numbers
                .Reverse()
                .ToArray();

            //foreach (var number in reversed)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}
