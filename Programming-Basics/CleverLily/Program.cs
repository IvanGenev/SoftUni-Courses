using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            double moneyGift = 10;
            int toysCount = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    savedMoney += moneyGift;
                    moneyGift += 10;
                    savedMoney--;
                }
                else
                {
                    toysCount++;
                }
            }
            double moneyFromToys = toysCount * toyPrice;
            savedMoney += moneyFromToys;

            if (savedMoney >= washingMashinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMashinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMashinePrice - savedMoney:f2}");
            }
        }
    }
}
