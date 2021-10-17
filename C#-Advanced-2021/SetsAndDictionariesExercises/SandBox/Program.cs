using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var parts = line.Split(' ');
                var name = parts[0];
                var grade = double.Parse(parts[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }

                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
