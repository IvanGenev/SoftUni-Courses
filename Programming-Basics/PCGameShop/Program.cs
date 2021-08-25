using System;

namespace PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGames = int.Parse(Console.ReadLine());

            int counterHearth = 0;
            int counterFort = 0;
            int counterOver = 0;
            int counterOther = 0;


            for (int i = 1; i <= numOfGames; i++)
            {
               

                string nameOfGame = Console.ReadLine();

                if (nameOfGame == "Hearthstone")
                {
                    counterHearth++;
                }
                else if (nameOfGame == "Fornite")
                {
                    counterFort++;
                }
                else if (nameOfGame == "Overwatch")
                {
                    counterOver++;
                }
                else
                {
                    counterOther++;
                }

            }

            Console.WriteLine($"Hearthstone - {counterHearth * 100.00 / numOfGames:f2}%");
            Console.WriteLine($"Fornite - {counterFort * 100.00 / numOfGames:f2}%");
            Console.WriteLine($"Overwatch - {counterOver * 100.00 / numOfGames:f2}%");
            Console.WriteLine($"Others - {counterOther * 100.00 / numOfGames:f2}%");
        }
    }
}
