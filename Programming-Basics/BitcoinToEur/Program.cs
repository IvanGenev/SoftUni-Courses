using System;

namespace BitcoinToEur
{
    class Program
    {
        static void Main(string[] args)
        {
            int Bitcoin = int.Parse(Console.ReadLine()) * 1168;
            double Juan = double.Parse(Console.ReadLine());
            double Commis = double.Parse(Console.ReadLine()) / 100;

            double USD = Juan * 0.15;
            double LEV = USD * 1.76;
            double sumLeva = Bitcoin + LEV;
            double EUR = sumLeva / 1.95;

            Console.WriteLine(EUR -= EUR * Commis);
        }
    }
}
