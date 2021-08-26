using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double totalTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;
            double studentTickets = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int ticketCounter = 0;
                string ticketType = Console.ReadLine();
                
                while (ticketType != "End")
                {
                    ticketCounter++;

                    switch (ticketType)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                    }
                    if (ticketCounter == availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                totalTickets += ticketCounter;
                double percentFull = (double)ticketCounter / availableSeats * 100;
                Console.WriteLine($"{movie} - {percentFull:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
