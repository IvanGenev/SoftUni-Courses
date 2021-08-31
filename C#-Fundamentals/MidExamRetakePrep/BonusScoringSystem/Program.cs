using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxStudentBonus = 0;
            double maxStudentAttendance = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / lecturesCount * (5 + initialBonus);

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
