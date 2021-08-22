using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());

            double priceBeforeDis = sqMeters * 7.61;
            double discount = priceBeforeDis * 0.18;

            Console.WriteLine($"The final price is: {(priceBeforeDis - discount)} lv.");
            Console.WriteLine($"The discount is: {discount}");
        }
    }
}
