using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>[A-Za-z]+)\>[^|$%.]*\|(?<count>[0-9]{1,})\|[^|$%.]*?(?<price>[0-9.]+?)\$$";

            string currentCustomer = string.Empty;
            string currentProduct = string.Empty;
            int currentCount = 0;
            decimal currentPrice = 0;
            decimal currentIncome = 0;
            decimal totalIncome = 0;

            while (input != "end of shift")
            {
                var validOrder = Regex.Matches(input, pattern);

                if (validOrder.Count == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                foreach (Match match in validOrder)
                {
                    currentCustomer = match.Groups["customer"].ToString();
                    currentProduct = match.Groups["product"].ToString();
                    currentCount = int.Parse(match.Groups["count"].Value);
                    currentPrice = decimal.Parse(match.Groups["price"].Value);
                    currentIncome = currentCount * currentPrice;

                    Console.WriteLine($"{currentCustomer}: {currentProduct} - {currentIncome:f2}");
                }


                totalIncome += currentIncome;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
