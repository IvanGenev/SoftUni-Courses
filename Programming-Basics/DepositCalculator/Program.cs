using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double anumPercentage = double.Parse(Console.ReadLine());

            Console.WriteLine(depositSum + (depositPeriod * ((depositSum * anumPercentage / 100) / 12)));
        }
    }
}
