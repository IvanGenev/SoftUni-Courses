using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> item = new();

            string order = Console.ReadLine();

            while (order != "end")
            {
                string[] orderArgs = order.Split(" ");

                int serialNumber = int.Parse(orderArgs[0]);
                string itemName = orderArgs[1];
                int itemQuantity = int.Parse(orderArgs[2]);
                int itemPrice = int.Parse(orderArgs[3]);

                
            }
        }
    }

    class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public int PriceForBox { get; set; }
    }
}
