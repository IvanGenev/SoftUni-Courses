using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();

            string currentPlayer = "";
            int goalsCurrentPlayer = 0;
            int maxGoals = int.MinValue;
            string bestPlayer = "";
            bool hatTrick = false;

            while (nameOfPlayer != "END")
            {
                int numOfGoals = int.Parse(Console.ReadLine());

                if (numOfGoals < 1 || numOfGoals > 10000)
                {
                    return;
                }

                currentPlayer = nameOfPlayer;
                goalsCurrentPlayer = numOfGoals;

                if (goalsCurrentPlayer > maxGoals)
                {
                    maxGoals = goalsCurrentPlayer;
                    bestPlayer = currentPlayer;
                }
                if (goalsCurrentPlayer >= 3)
                {
                    hatTrick = true;
                }
                if (goalsCurrentPlayer >= 10)
                {
                    break;
                }
                nameOfPlayer = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");

            if (hatTrick)
            {
                Console.WriteLine($"He has scored {goalsCurrentPlayer} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsCurrentPlayer} goals.");
            }
        }
    }
}
