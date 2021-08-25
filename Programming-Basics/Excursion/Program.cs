using System;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            int numTransportCards = int.Parse(Console.ReadLine());
            int numMuseumTickets = int.Parse(Console.ReadLine());

            double costOfNights = numNights * 20;
            double costOfTransport = numTransportCards * 1.60;
            double costOfMuseums = numMuseumTickets * 6;

            double totalForOne = costOfNights + costOfTransport + costOfMuseums;
            double totalForAll = totalForOne * numOfPeople;
            double totalWithAdditionalCosts = totalForAll * 1.25;

            Console.WriteLine($"{totalWithAdditionalCosts:f2}");
        }
    }
}
