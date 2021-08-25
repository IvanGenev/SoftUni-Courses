using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numOfDrinks = int.Parse(Console.ReadLine());

            double pricePerDrink = 0;

            if (drink == "Espresso")
            {
                switch (sugar)
                {
                    case "Without":
                        pricePerDrink = 0.90 * 0.65;
                        break;
                    case "Normal":
                        pricePerDrink = 1.00;
                        break;
                    case "Extra":
                        pricePerDrink = 1.20;
                        break;
                }
                if (numOfDrinks >= 5)
                {
                    pricePerDrink -= pricePerDrink * 0.25;
                }
            }
            else if (drink == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without":
                        pricePerDrink = 1.00 * 0.65;
                        break;
                    case "Normal":
                        pricePerDrink = 1.20;
                        break;
                    case "Extra":
                        pricePerDrink = 1.60;
                        break;
                }
            }
            else if (drink == "Tea")
            {
                switch (sugar)
                {
                    case "Without":
                        pricePerDrink = 0.50 * 0.65;
                        break;
                    case "Normal":
                        pricePerDrink = 0.60;
                        break;
                    case "Extra":
                        pricePerDrink = 0.70;
                        break;
                }
            }
            double totalSum = pricePerDrink * numOfDrinks;
            if (totalSum > 15)
            {
                totalSum -= totalSum * 0.20;
            }
            Console.WriteLine($"You bought {numOfDrinks} cups of {drink} for {totalSum:f2} lv.");
        }
    }
}
