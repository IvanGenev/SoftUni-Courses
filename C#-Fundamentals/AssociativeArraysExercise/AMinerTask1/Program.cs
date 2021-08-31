using System;
using System.Collections.Generic;

namespace AMinerTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> resourceQty = new Dictionary<string, int>();

            for (int i = 0; ; i++)
            {
                string resourse = Console.ReadLine();

                if (resourse.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resourceQty.ContainsKey(resourse))
                {
                    resourceQty.Add(resourse, 0);
                }

                resourceQty[resourse] += quantity;
            }

            foreach (var item in resourceQty)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
