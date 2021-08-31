using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<type>[A-Za-z]+)<<(?<price>[0-9]+\.{0,1}[0-9]{0,})!(?<qty>[0-9]+)";

            string input = Console.ReadLine();

            Console.WriteLine("Bought furniture:");

            decimal totalPrice = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string productName = match.Groups[1].Value;
                decimal productPrice = decimal.Parse(match.Groups[2].Value);
                int productQTY = int.Parse(match.Groups[3].Value);

                totalPrice += productPrice * productQTY;

                Console.WriteLine(productName);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
