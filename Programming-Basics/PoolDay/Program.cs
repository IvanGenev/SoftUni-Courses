using System;

namespace PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double pricePerSunbed = double.Parse(Console.ReadLine());
            double pricePerUmbrella = double.Parse(Console.ReadLine());

            double totalEntranceFee = numOfPeople * entranceFee;
            double totalPriceUmbrellas = Math.Ceiling(numOfPeople / 2.0) * pricePerUmbrella;
            double totalPriceSunbeds = Math.Ceiling(numOfPeople * 0.75) * pricePerSunbed;

            double total = totalEntranceFee + totalPriceUmbrellas + totalPriceSunbeds;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
