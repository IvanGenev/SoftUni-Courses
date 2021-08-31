using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnlineWithClasses
{
    class DungeonRunner
    {
        public int Health { get; set; }

        public int Coins { get; set; }

        public void Heal(int amount)
        {
            Health += amount;

            if (Health > 100)
            {
                amount -= Health - 100;
                Health = 100;
            }

            Console.WriteLine($"You healed for {amount} hp.");
            Console.WriteLine($"Current health: {Health} hp.");
        }

        public void CollectChest(int amount)
        {
            Console.WriteLine($"You found {amount} bitcoins.");
            Coins += amount;
        }

        public bool AttackMonster(string monsterName, int amount, int room)
        {
            if (Health > amount)
            {
                Console.WriteLine($"You slayed {monsterName}.");
                Health -= amount;
                return false;
            }
            else
            {
                Console.WriteLine($"You died! Killed by {monsterName}.");
                Console.WriteLine($"Best room: {room}");
                return true;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string[] rooms = Console.ReadLine().Split("|");

            bool isDead = false;

            DungeonRunner runner = new DungeonRunner() { Health = 100, Coins = 0 };

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] splitted = rooms[i].Split(" ");
                string command = splitted[0];
                int amount = int.Parse(splitted[1]);

                if (command == "potion")
                {
                    runner.Heal(amount);
                }
                else if (command == "chest")
                {
                    runner.CollectChest(amount);
                }
                else
                {
                    if (runner.AttackMonster(command, amount, i + 1))
                    {
                        isDead = true;
                        break;
                    }
                }
            }

            if (!isDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {runner.Coins}");
                Console.WriteLine($"Health: {runner.Health}");
            }
        }
    }
}
