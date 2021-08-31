using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsDictionary = new Dictionary<string, List<double>>();

            int numberOfPairs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPairs; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsDictionary.ContainsKey(studentName))
                {
                    studentsDictionary.Add(studentName, new List<double>());
                }

                studentsDictionary[studentName].Add(studentGrade);
            }

            foreach (var item in studentsDictionary
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
