using System;
using System.Collections.Generic;
using System.Linq;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main()
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            double maxStudentBonus = 0;
            double maxStudentAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / lecturesCount
                * (5 + initialBonus);

                if (totalBonus > maxStudentBonus)
                {
                    maxStudentBonus = totalBonus;
                    maxStudentAttendance = studentAttendance;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxStudentBonus)}.");
            Console.WriteLine($"The student has attended {Math.Ceiling(maxStudentAttendance)} lectures.");
        }
    }
}
