using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int winCount = 0;
            int cycleCount = 0;

            while (input != "End of battle")
            {
                int energyNeeded = int.Parse(input);
                
                if (initialEnergy < energyNeeded)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCount} won battles and {initialEnergy} energy");
                    return;
                }
                else
                {
                    initialEnergy -= energyNeeded;
                    winCount++;
                    cycleCount++;
                }

                if (cycleCount % 3 == 0)
                {
                    initialEnergy += winCount;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {winCount}. Energy left: {initialEnergy}");
        }
    }
}
