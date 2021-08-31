using System;

namespace BonusScoringSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double strudentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initiailBonus = double.Parse(Console.ReadLine());

            double maxStudentBonus = 0;
            double maxStudentAttendance = 0;

            for (int i = 0; i < strudentsCount; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / lecturesCount * (5 + initiailBonus);

                if (totalBonus > maxStudentBonus)
                {
                    maxStudentBonus = totalBonus;
                    maxStudentAttendance = studentAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxStudentBonus)}");
            Console.WriteLine($"The student has attended {Math.Ceiling(maxStudentAttendance)} lectures.");
        }
    }
}
