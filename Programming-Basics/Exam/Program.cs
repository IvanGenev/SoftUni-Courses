using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            double groupOne = 0;
            double groupTwo = 0;
            double groupThree = 0;
            double groupFour = 0;
            double grade = 0;

            for (int i = 1; i <= numOfStudents; i++)
            {
                double gradeStudent = double.Parse(Console.ReadLine());

                grade += gradeStudent;

                if (gradeStudent >= 2.00 && gradeStudent <= 2.99)
                {
                    groupFour++;
                }
                else if (gradeStudent >= 3.00 && gradeStudent <= 3.99)
                {
                    groupThree++;
                }
                else if (gradeStudent >= 4.00 && gradeStudent <= 4.99)
                {
                    groupTwo++;
                }
                else if (gradeStudent >= 5.00)
                {
                    groupOne++;
                }
            }
            double averageGrade = grade / numOfStudents;

            Console.WriteLine($"Top students: {groupOne * 100 / numOfStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {groupTwo * 100 / numOfStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {groupThree * 100 / numOfStudents:f2}%");
            Console.WriteLine($"Fail: {groupFour * 100 / numOfStudents:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
