using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasKG = double.Parse(Console.ReadLine());
            double orangesKG = double.Parse(Console.ReadLine());
            double raspberriesKG = double.Parse(Console.ReadLine());
            double strawberriesKG = double.Parse(Console.ReadLine());

            double totalStrawberries = strawberriesPrice * strawberriesKG;
            double raspberriesPrice = strawberriesPrice / 2;
            double totalRaspberries = raspberriesPrice * raspberriesKG;
            double orangesPrice = raspberriesPrice * 0.6;
            double totalOranges = orangesPrice * orangesKG;
            double bananasPrice = raspberriesPrice * 0.2;
            double totalBananas = bananasPrice * bananasKG;

            double totaFruits = Math.Round((totalStrawberries + totalRaspberries + totalOranges + totalBananas), 2);

            Console.WriteLine(totaFruits);
        }
    }
}
