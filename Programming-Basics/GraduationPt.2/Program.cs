using System;

namespace GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classes = 1;
            double sum = 0;
            int excluded = 0;

            while (classes <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    excluded++;
                    if (excluded > 1)
                    {
                        break;
                    }
                    continue;
                }

                sum += grade;
                classes++;
            }
            double averageGrade = sum / 12;

            if (excluded > 1)
            {
                Console.WriteLine($"{name} has been excluded at {classes} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
