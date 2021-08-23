using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialSpeed = int.Parse(Console.ReadLine());
            int timeOne = int.Parse(Console.ReadLine());
            int timeTwo = int.Parse(Console.ReadLine());
            int timeThree = int.Parse(Console.ReadLine());

            double distanceOne = initialSpeed * (timeOne / 60.0);
            double speedTwo = initialSpeed * 1.10;
            double distanceTwo = speedTwo * (timeTwo / 60.0);
            double speedThree = speedTwo * 0.95;
            double distanceThree = speedThree * (timeThree / 60.0);

            double totalDistance = distanceOne + distanceTwo + distanceThree;

            Console.WriteLine($"{totalDistance:f2}");
        }
    }
}
