using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyNylon = int.Parse(Console.ReadLine());
            int qtyPaint = int.Parse(Console.ReadLine());
            int qtyThinner = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            double priceNylon = (qtyNylon + 2) * 1.50;
            double pricePaint = (qtyPaint * 1.10) * 14.50;
            double priceThinner = qtyThinner * 5.00;

            double totalProductsPrice = priceNylon + pricePaint + priceThinner + 0.40;

            double workPrice = totalProductsPrice * 0.30 * workingHours;

            double totalExpenses = totalProductsPrice + workPrice;

            Console.WriteLine($"Total expenses: {totalExpenses:f2} lv.");
        }
    }
}
