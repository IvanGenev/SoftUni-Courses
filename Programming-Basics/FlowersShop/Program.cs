using System;

namespace FlowersShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfChrisantemi = int.Parse(Console.ReadLine());
            int numOfRoses = int.Parse(Console.ReadLine());
            int numOfTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();

            double priceChrisantemi = 0;
            double priceRoses = 0;
            double priceTulips = 0;

            int totalFlowers = numOfChrisantemi + numOfRoses + numOfTulips;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    if (holidayOrNot == "Y")
                    {
                        priceChrisantemi = 2.00 * 1.15;
                        priceRoses = 4.10 * 1.15;
                        priceTulips = 2.50 * 1.15;
                    }
                    else
                    {
                        priceChrisantemi = 2.00;
                        priceRoses = 4.10;
                        priceTulips = 2.50;
                    }
                    break;
                case "Autumn":
                case "Winter":
                    if (holidayOrNot == "Y")
                    {
                        priceChrisantemi = 3.75 * 1.15;
                        priceRoses = 4.50 * 1.15;
                        priceTulips = 4.15 * 1.15;
                    }
                    else
                    {
                        priceChrisantemi = 3.75;
                        priceRoses = 4.50;
                        priceTulips = 4.15;
                    }
                    break;
            }
            if (season == "Spring" && numOfTulips > 7)
            {
                priceTulips *= 0.95;
            }
            if (season == "Winter" && numOfRoses >= 10)
            {
                priceRoses *= 0.90;
            }
            double totalCostChrisantemi = numOfChrisantemi * priceChrisantemi;
            double totalCostRoses = numOfRoses * priceRoses;
            double totalCostTulips = numOfTulips * priceTulips;
            double preparingOfBouquet = 2.00;
            double totalCostBouquet = totalCostChrisantemi + totalCostRoses + totalCostTulips + preparingOfBouquet;

            if (totalFlowers > 20)
            {
                totalCostBouquet *= 0.80;
            }

            Console.WriteLine($"{totalCostBouquet:f2}");
        }
    }
}
