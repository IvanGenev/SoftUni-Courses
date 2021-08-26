using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeSecPerMeter = double.Parse(Console.ReadLine());

            double resistance = Math.Floor(distanceInMeters / 15) * 12.5;
            double newTime = (distanceInMeters * timeSecPerMeter) + resistance;

            if (oldRecordInSeconds > newTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is " +
                    $"{Math.Round(newTime, 2):0.00} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was " +
                    $"{Math.Round((newTime - oldRecordInSeconds), 2):0.00} seconds slower.");
            }
        }
    }
}
