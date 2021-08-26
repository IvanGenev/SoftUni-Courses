using System;

namespace DailyEarnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInMonth = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double USD = double.Parse(Console.ReadLine());

            double moneyPerMonth = moneyPerDay * daysInMonth;
            double moneyPerYear = moneyPerMonth * 12 + moneyPerMonth * 2.5;
            double taxes = moneyPerYear * 0.25;
            double moneyPerYearNet = (moneyPerYear - taxes) * USD;
            double moneyPerDayNet = moneyPerYearNet / 365;

            Console.WriteLine(Math.Round(moneyPerDayNet, 2));
        }
    }
}
