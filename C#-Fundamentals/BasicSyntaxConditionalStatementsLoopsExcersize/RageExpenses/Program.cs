using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double moucePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = (headsetPrice * (lostGamesCount / 2)) +
                (moucePrice * (lostGamesCount / 3)) +
                (keyboardPrice * (lostGamesCount / 6)) +
                (displayPrice * (lostGamesCount / 12));


            // Another version using loop:

            //for (int i = 1; i < lostGamesCount; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        money += headsetPrice;
            //    }

            //    if (i % 3 == 0)
            //    {
            //        money += moucePrice;
            //    }

            //    if (i % 6 == 0)
            //    {
            //        money += keyboardPrice;
            //    }

            //    if (i % 12 == 0)
            //    {
            //        money += displayPrice;
            //    }
            //}

            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
