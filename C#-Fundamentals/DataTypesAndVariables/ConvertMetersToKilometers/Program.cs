using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            float kilometers = meters / 1000.0F;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
