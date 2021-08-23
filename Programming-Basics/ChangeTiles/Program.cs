using System;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHight = double.Parse(Console.ReadLine());
            double priceTile = double.Parse(Console.ReadLine());
            double priceLabor = double.Parse(Console.ReadLine());

            double floorArea = floorLength * floorWidth;
            double tileArea = triangleSide * triangleHight / 2;
            double neededTiles = Math.Ceiling(floorArea / tileArea) + 5;

            double moneyNeeded = neededTiles * priceTile + priceLabor;

            if (moneyHave >= moneyNeeded)
            {
                Console.WriteLine($"{moneyHave - moneyNeeded:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {moneyNeeded - moneyHave:f2} lv more.");
            }
        }
    }
}
