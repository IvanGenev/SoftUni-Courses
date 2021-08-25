using System;

namespace EsterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCakes = int.Parse(Console.ReadLine());

            int maxPoints = int.MinValue;
            string bestChef = "";

            for (int i = 0; i < numOfCakes; i++)
            {
                string nameOfChef = Console.ReadLine();

                int totalPoints = 0;

                string command = Console.ReadLine();

                while (command != "Stop")
                {
                    int points = int.Parse(command);

                    totalPoints += points;

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{nameOfChef} has {totalPoints} points.");

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    bestChef = nameOfChef;
                    Console.WriteLine($"{nameOfChef} is the new number 1!");
                }
            }
            Console.WriteLine($"{bestChef} won competition with {maxPoints} points!");
        }
    }
}
