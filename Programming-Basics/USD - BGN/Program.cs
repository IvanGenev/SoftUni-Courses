using System;

namespace USD___BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD - ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine("BGN - " + Math.Round(bgn, 2));
        }
    }
}
