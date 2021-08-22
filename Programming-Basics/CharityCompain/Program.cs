using System;

namespace CharityCompain
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int numCookers = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numGofre = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());

            double totaCakes = numCakes * 45;
            double totalGofre = numGofre * 5.8;
            double totalPancakes = numPancakes * 3.2;

            double totalPerDay = (totaCakes + totalGofre + totalPancakes) * numCookers;

            double total = totalPerDay * numDays;

            Console.WriteLine(total - (total / 8));
        }
    }
}
