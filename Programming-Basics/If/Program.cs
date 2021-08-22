using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount - ");
            var amount = double.Parse(Console.ReadLine());
            Console.Write("Enter 1st Currency - ");
            var currencyFrom = Console.ReadLine();
            Console.Write("Enter 2nd Currency - ");
            var currencyTo = Console.ReadLine();
            if (currencyFrom == "BGN" & currencyTo == "EUR")
            {
                Console.WriteLine(Math.Round(amount / 1.95583, 2) + " EUR");
            }
            else if (currencyFrom == "EUR" & currencyTo == "BGN")
            {
                Console.WriteLine(Math.Round(amount * 1.95583, 2) + " BGN");
            }
            else if (currencyFrom == "BGN" & currencyTo == "USD")
            {
                Console.WriteLine(Math.Round(amount / 1.79549, 2) + " USD");
            }
            else if (currencyFrom == "USD" & currencyTo == "BGN")
            {
                Console.WriteLine(Math.Round(amount * 1.79549, 2) + " BGN");
            }
            else if (currencyFrom == "BGN" & currencyTo == "GBP")
            {
                Console.WriteLine(Math.Round(amount / 2.53405, 2) + " GBP");
            }
            else if (currencyFrom == "GBP" & currencyTo == "BGN")
            {
                Console.WriteLine(Math.Round(amount * 2.53405, 2) + " BGN");
            }
            else if (currencyFrom == "USD" & currencyTo == "EUR")
            {
                Console.WriteLine(Math.Round((amount * 1.79549) / 1.95583, 2) + " EUR");
            }
            else if (currencyFrom == "EUR" & currencyTo == "USD")
            {
                Console.WriteLine(Math.Round((amount * 1.95583) / 1.79549, 2) + " USD");
            }
            else if (currencyFrom == "USD" & currencyTo == "GBP")
            {
                Console.WriteLine(Math.Round((amount * 1.79549) / 2.53405, 2) + " GBP");
            }
            else if (currencyFrom == "GBP" & currencyTo == "USD")
            {
                Console.WriteLine(Math.Round((amount * 2.53405) / 1.79549, 2) + " USD");
            }
            else if (currencyFrom == "EUR" & currencyTo == "GBP")
            {
                Console.WriteLine(Math.Round((amount * 1.95583) / 2.53405, 2) + " GBP");
            }
            else if (currencyFrom == "GBP" & currencyTo == "EUR")
            {
                Console.WriteLine(Math.Round((amount * 2.53405) / 1.95583, 2) + " EUR");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Enter valid currency!");
                Console.ReadKey();
            }
        }
    }
}
