using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            
            double water = pipe1 * hours + pipe2 * hours;

            if (water <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate(water / volume * 100),
                    Math.Truncate(pipe1 * hours / water * 100),
                    Math.Truncate(pipe2 * hours / water * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
            }
        }
    }
}
