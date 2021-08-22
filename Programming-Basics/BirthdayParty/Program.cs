using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double cake = (hallRent * 0.20);
            double drinks = cake - (cake * 0.45);
            double anime = hallRent / 3;

            double total = hallRent + cake + drinks + anime;

            Console.WriteLine(total);
        }
    }
}
