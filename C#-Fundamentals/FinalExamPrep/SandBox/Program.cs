using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> personHealth = new Dictionary<string, int>();
            Dictionary<string, int> personEnergy = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "Results")
            {
                var splitted = command.Split(":");
                string commandName = splitted[0];

                if (commandName.Contains("Add"))
                {
                    string personName = splitted[1];
                    int health = int.Parse(splitted[2]);
                    int energy = int.Parse(splitted[3]);

                    if (personHealth.ContainsKey(personName))
                    {
                        personHealth[personName] += health;
                    }
                    else
                    {
                        personHealth.Add(personName, health);
                        personEnergy.Add(personName, energy);
                    }
                }
                if (command.Contains("Attack"))
                {
                    string attackerName = splitted[1];
                    string defenderName = splitted[2];
                    int damage = int.Parse(splitted[3]);

                    if (personHealth.ContainsKey(attackerName) && personHealth.ContainsKey(defenderName))
                    {
                        personHealth[defenderName] -= damage;
                        personEnergy[attackerName] -= 1;

                        if (personHealth[defenderName] <= 0)
                        {
                            personHealth.Remove(defenderName);
                            personEnergy.Remove(defenderName);

                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        if (personEnergy[attackerName] <= 0)
                        {
                            personHealth.Remove(attackerName);
                            personEnergy.Remove(attackerName);

                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                }

                if (command.Contains("Delete"))
                {
                    string username = splitted[1];

                    if (username == "All")
                    {
                        personEnergy.Clear();
                        personHealth.Clear();
                    }
                    if (personHealth.ContainsKey(username) && personEnergy.ContainsKey(username))
                    {
                        personHealth.Remove(username);
                        personEnergy.Remove(username);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"People count: {personHealth.Count()}");

            personHealth = personHealth
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var person in personHealth)
            {
                Console.WriteLine($"{person.Key} - {person.Value} - {personEnergy[person.Key]}");
            }
        }
    }
}
