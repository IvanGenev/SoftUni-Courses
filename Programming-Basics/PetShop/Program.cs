using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodQty = int.Parse(Console.ReadLine());
            int animalFoodQty = int.Parse(Console.ReadLine());

            double dogFoodCost = dogFoodQty * 2.5;
            int animalFoodCost = animalFoodQty * 4;

            double totalCost = dogFoodCost + animalFoodCost;

            Console.WriteLine($"{totalCost} lv.");
        }
    }
}
