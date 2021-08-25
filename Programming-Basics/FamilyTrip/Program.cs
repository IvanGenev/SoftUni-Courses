using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetForVacation = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percentageAdditionalCosts = int.Parse(Console.ReadLine());


            if (nights > 7)
            {
                pricePerNight -= pricePerNight * 0.05;
            }

            double totalCost = pricePerNight * nights;

            double additionalExpenses = budgetForVacation * percentageAdditionalCosts / 100;

            double moneyNeeded = totalCost + additionalExpenses;

            if (budgetForVacation >= moneyNeeded)
            {
                Console.WriteLine($"Ivanovi will be left with {budgetForVacation - moneyNeeded:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{moneyNeeded - budgetForVacation:f2} leva needed.");
            }
        }
    }
}
