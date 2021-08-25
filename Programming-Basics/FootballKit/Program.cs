using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTshirt = double.Parse(Console.ReadLine());
            double desirableSum = double.Parse(Console.ReadLine());

            double priceShorts = priceTshirt * 0.75;
            double priceSocks = priceShorts * 0.20;
            double priceShoes = (priceTshirt + priceShorts) * 2;

            double totalSum = (priceTshirt + priceShorts + priceSocks + priceShoes) * 0.85;

            if (totalSum >= desirableSum)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {desirableSum - totalSum:f2} lv. more.");
            }
        }
    }
}
