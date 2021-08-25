using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            double profit = 0;

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                int numOfCocktails = int.Parse(Console.ReadLine());

                double priceOfCurrentCocktail = command.Length;
                double priceOfOrder = priceOfCurrentCocktail * numOfCocktails;

                if (priceOfOrder % 2 != 0)
                {
                    priceOfOrder -= priceOfOrder * 0.25;
                }

                profit += priceOfOrder;

                if (profit >= desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Party!")
            {
                Console.WriteLine($"We need {desiredProfit - profit:f2} leva more.");
            }

            Console.WriteLine($"Club income - {profit:f2} leva.");
        }
    }
}
