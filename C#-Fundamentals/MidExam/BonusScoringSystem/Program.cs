using System;
using System.Collections.Generic;
using System.Linq;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAttendances = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                double countOfAttendances = double.Parse(Console.ReadLine());

                double totalBonus = countOfAttendances / countOfLectures * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = countOfAttendances;
                }
            }

            Console.WriteLine("Max Bonus: {0}.", Math.Ceiling(maxBonus));
            Console.WriteLine("The student has attended {0} lectures.", maxAttendances);

        }
    }
}
