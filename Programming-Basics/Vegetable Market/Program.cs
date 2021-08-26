using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegPerKg = int.Parse(Console.ReadLine());
            int fruitPerKg = int.Parse(Console.ReadLine());

            Console.WriteLine((vegPrice * vegPerKg + fruitPrice * fruitPerKg) / 1.94);
        }
    }
}
