using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main()
        {
            double pounds = double.Parse(Console.ReadLine());

            double dollar = pounds * 1.310;

            Console.WriteLine($"{dollar:F3}");
        }
    }
}
