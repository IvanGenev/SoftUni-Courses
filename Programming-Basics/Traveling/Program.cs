using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                
                double minBudget = double.Parse(Console.ReadLine());
                double safedMoney = 0;

                while (safedMoney < minBudget)
                {
                    safedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
