using System;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDancers = int.Parse(Console.ReadLine());
            double numOfPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double sumTotalPoints = numOfDancers * numOfPoints;

            if (place == "Abroad")
            {
                sumTotalPoints *= 1.50;

                if (season == "summer")
                {
                    sumTotalPoints *= 0.90;
                }
                else if (season == "winter")
                {
                    sumTotalPoints *= 0.85;
                }
            }
            if (place == "Bulgaria")
            {
                if (season == "summer")
                {
                    sumTotalPoints *= 0.95;
                }
                else if (season == "winter")
                {
                    sumTotalPoints *= 0.92;
                }
            }
            double sumForCharity = sumTotalPoints * 0.75;

            double sumForOne = (sumTotalPoints - sumForCharity) / numOfDancers;

            Console.WriteLine($"Charity - {sumForCharity:f2}");
            Console.WriteLine($"Money per dancer - {sumForOne:f2}");
        }
    }
}
