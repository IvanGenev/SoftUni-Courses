using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grapeKg = double.Parse(Console.ReadLine());
            var wineNeed = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var harvestArea = area * 0.40;
            var harvest = harvestArea * grapeKg;
            var wineLiters = harvest / 2.5;

            if (wineLiters < wineNeed)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor((wineNeed - wineLiters))} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor((wineLiters))} liters.");
                Console.WriteLine($"{Math.Ceiling((wineLiters - wineNeed))} liters left -> {Math.Ceiling(((wineLiters - wineNeed) / workers))} liters per person.");
            }
        }
    }
}
