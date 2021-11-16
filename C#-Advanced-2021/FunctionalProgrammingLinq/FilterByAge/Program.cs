using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                var parts = line.Split(", ");
                string name = parts[0];
                int age = int.Parse(parts[1]);

                var person = new Person();
                person.Name = parts[0];
                person.Age = int.Parse(parts[1]);

                people.Add(person);
            }

            var filterName = Console.ReadLine();
            var ageToCompare = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = p => true;

            if (filterName == "younger")
            {
                filter = p => p.Age < ageToCompare;
            }
            else if (filterName == "older")
            {
                filter = p => p.Age > ageToCompare;
            }
            else if (filterName == "exact")
            {
                filter = p => p.Age == ageToCompare;
            }

            var filteredPeople = people.Where(filter);

            var printOutput = Console.ReadLine();

            Func<Person, string> func = p => p.Name + " " + p.Age;

            if (printOutput == "name age")
            {
                func = p => p.Name + " - " + p.Age;
            }
            else if (printOutput == "name")
            {
                func = p => p.Name;
            }
            else if (printOutput == "age")
            {
                func = p => p.Age.ToString();
            }

            var personAsString = filteredPeople.Select(func);

            foreach (var str in personAsString)
            {
                Console.WriteLine(str);
            }
        }
    }
}
