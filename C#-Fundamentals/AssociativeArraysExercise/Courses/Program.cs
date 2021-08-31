using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesDictionary = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            string courseName = string.Empty;
            string studentName = string.Empty;

            while (input != "end")
            {
                string[] splittedInput = input.Split(" : ");
                courseName = splittedInput[0];
                studentName = splittedInput[1];

                if (!coursesDictionary.ContainsKey(courseName))
                {
                    coursesDictionary.Add(courseName, new List<string>());
                }

                coursesDictionary[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            foreach (var item in coursesDictionary
                .OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
