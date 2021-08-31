using System;

namespace Orders
{
    class Program
    {
        static double PriceOfOrder(string product, double quantity)
        {
            double sum = 0;

            switch (product)
            {
                case "coffee":
                    sum = quantity * 1.50;
                    break;
                case "water":
                    sum = quantity * 1.00;
                    break;
                case "coke":
                    sum = quantity * 1.40;
                    break;
                case "snacks":
                    sum = quantity * 2.00;
                    break;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = PriceOfOrder(product, quantity);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
