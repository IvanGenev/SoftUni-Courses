using System;

namespace FitnesCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 1; i <= numOfPeople; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        back++;
                        break;
                    case "Chest":
                        chest++;
                        break;
                    case "Legs":
                        legs++;
                        break;
                    case "Abs":
                        abs++;
                        break;
                    case "Protein shake":
                        proteinShake++;
                        break;
                    case "Protein bar":
                        proteinBar++;
                        break;
                }
            }
            int peopleWhoTrain = back + chest + legs + abs;
            int poepleWhoBuyProtein = proteinBar + proteinShake;

            double percentOfTrainingPeople = peopleWhoTrain * 1.0 / numOfPeople * 100;
            double percentOfPeopleWhoBuyProtein = poepleWhoBuyProtein * 1.0 / numOfPeople * 100;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentOfTrainingPeople:f2}% - work out");
            Console.WriteLine($"{percentOfPeopleWhoBuyProtein:f2}% - protein");

        }
    }
}
