using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double sumAllGrades = 0;
            int gradeCount = 0;

            while (input != "Finish")
            {
                double sumGrade = 0;
                for (int i = 1; i <= juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrade += grade;
                    sumAllGrades += grade;
                    gradeCount++;
                }
                double average = sumGrade / juryCount;
                Console.WriteLine($"{input} - {average:f2}.");
                input = Console.ReadLine();
            }
            double finalGrade = sumAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");

        }
    }
}
