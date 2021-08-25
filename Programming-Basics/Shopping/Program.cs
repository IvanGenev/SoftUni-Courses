using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfGPU = int.Parse(Console.ReadLine());
            int numOfCPU = int.Parse(Console.ReadLine());
            int numOfRAM = int.Parse(Console.ReadLine());

            const double priceGPU = 250.00;
            double totalGPU = priceGPU * numOfGPU;
            double priceCPU = totalGPU * 0.35;
            double totalCPU = priceCPU * numOfCPU;
            double priceRAM = totalGPU * 0.10;
            double totalRAM = priceRAM * numOfRAM;

            double grandTotal = totalGPU + totalCPU + totalRAM;

            if (numOfGPU > numOfCPU)
            {
                grandTotal *= 0.85;
            }

            if (budget >= grandTotal)
            {
                Console.WriteLine($"You have {budget - grandTotal:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(grandTotal - budget):f2} leva more!");
            }
        }
    }
}
