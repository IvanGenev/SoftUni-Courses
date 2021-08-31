using System;

namespace GenerateRandomNumbers
{
    class RandomNumbersBetween1And49
    {
        static void Main()
        {
            // Generate 6 random numbers between 1 and 49
            Random rand = new Random();
            for (int number = 1; number <= 6; number++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }
        }
    }
}
