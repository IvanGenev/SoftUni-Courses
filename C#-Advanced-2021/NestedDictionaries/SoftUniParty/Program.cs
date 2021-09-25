using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            bool partystarted = false;
            HashSet<string> vipPeople = new HashSet<string>();
            HashSet<string> normalPeople = new HashSet<string>();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partystarted = true;
                    continue;
                }

                if (partystarted)
                {
                    if (IsVip(command))
                    {
                        vipPeople.Remove(command);
                    }
                    else
                    {
                        normalPeople.Remove(command);
                    }
                }
                else
                {
                    if (IsVip(command))
                    {
                        vipPeople.Add(command);
                    }
                    else
                    {
                        normalPeople.Add(command);
                    }
                }
            }

            Console.WriteLine(vipPeople.Count + normalPeople.Count);

            foreach (var person in vipPeople)
            {
                Console.WriteLine(person);
            }
            
            foreach (var person in normalPeople)
            {
                Console.WriteLine(person);
            }
        }

        private static bool IsVip(string number)
        {
            int num = 0;

            return int.TryParse(number.Substring(0, 1), out num);
        }
    }
}
