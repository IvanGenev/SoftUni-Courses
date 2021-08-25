using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string VIP = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pricePerDay = 0;
            double discount = 0;
            double totalPrice = 0;

            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            if (days > 7)
            {
                days--;
            }

            if (city == "Bansko" || city == "Borovets")
            {
                if (packet == "withEquipment")
                {
                    pricePerDay = 100;
                    discount = 0.10;
                }
                else if (packet == "noEquipment")
                {
                    pricePerDay = 80;
                    discount = 0.05;
                }
            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (packet == "withBreakfast")
                {
                    pricePerDay = 130;
                    discount = 0.12;
                }
                else if (packet == "noBreakfast")
                {
                    pricePerDay = 100;
                    discount = 0.07;
                }
            }
            
            if (VIP == "yes")
            {
                pricePerDay -= pricePerDay * discount;
            }

            totalPrice = pricePerDay * days;

            if (totalPrice > 0)
            {
                Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
