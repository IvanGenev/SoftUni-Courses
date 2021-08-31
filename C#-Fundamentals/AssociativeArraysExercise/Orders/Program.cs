﻿using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputInfo = input.Split();
                string productName = inputInfo[0];
                double productPrice = double.Parse(inputInfo[1]);
                int productQty = int.Parse(inputInfo[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }

                double previousQty = products[productName][1];
                double[] priceQty = new double[] { productPrice, previousQty + productQty };
                products[productName] = priceQty;

                input = Console.ReadLine();
            }

            foreach (var productKvp in products)
            {
                double totalPrice = productKvp.Value[0] * productKvp.Value[1];
                Console.WriteLine($"{productKvp.Key} -> {totalPrice:f2}");
            }
        }
    }
}
