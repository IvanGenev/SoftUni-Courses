using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyDictionary = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(" -> ");

                string companyName = splittedInput[0];
                string employeeId = splittedInput[1];

                if (!companyDictionary.ContainsKey(companyName))
                {
                    companyDictionary.Add(companyName, new List<string>());
                }

                if (!companyDictionary[companyName].Contains(employeeId))
                {
                    companyDictionary[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var item in companyDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");

                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
