using System;

namespace GodzilaKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            double decor = budget * 0.10;

            if (actors > 150)
            {
                clothingPrice *= 0.90;
            }
            
            double totalExpenses = decor + (clothingPrice * actors);

            if (budget < totalExpenses)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Round((totalExpenses - budget),2):0.00} leva more.");
            }
            if (totalExpenses < budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Round((budget - totalExpenses),2):0.00} leva left.");
            }
        }
    }
}
