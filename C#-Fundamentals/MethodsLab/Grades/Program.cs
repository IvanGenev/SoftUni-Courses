using System;

namespace Grades
{
    class Program
    {
        static void PrintGrade(double grade)
        {
            //if (grade >= 2.00 && grade <= 2.99)
            //    Console.WriteLine("Fail");
            //else if (grade >= 3.00 && grade <= 3.49)
            //    Console.WriteLine("Poor");
            //else if (grade >= 3.50 && grade <= 4.49)
            //    Console.WriteLine("Good");
            //else if (grade >= 4.50 && grade <= 5.49)
            //    Console.WriteLine("Very good");
            //else if (grade >= 5.50 && grade <= 6.00)
            //    Console.WriteLine("Excellent");

            // Another version with a string:

            string gradesInWords = string.Empty;

            if (grade >= 2.00 && grade <= 2.99)
                gradesInWords = "Fail";
            else if (grade >= 3.00 && grade <= 3.49)
                gradesInWords = "Poor";
            else if (grade >= 3.50 && grade <= 4.49)
                gradesInWords = "Good";
            else if (grade >= 4.50 && grade <= 5.49)
                gradesInWords = "Very good";
            else if (grade >= 5.50 && grade <= 6.00)
                gradesInWords = "Excellent";

            Console.WriteLine(gradesInWords);
        }

        static void Main(string[] args)
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }
    }
}
