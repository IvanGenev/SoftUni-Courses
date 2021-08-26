using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int totalVolume = width * lenght * height;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int numBoxes = int.Parse(input);
                totalVolume -= numBoxes;

                if (totalVolume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(totalVolume)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{totalVolume} Cubic meters left.");
            }
        }
    }
}
