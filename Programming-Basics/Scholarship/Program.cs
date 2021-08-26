using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double socialScholarship = minWage * 0.35;
            double excellentScholarship = grade * 25;

            if (income > minWage && grade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minWage && grade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (grade >= 5.5)
            {
                Console.WriteLine($"You get scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if (excellentScholarship == socialScholarship)
            {
                Console.WriteLine($"You get scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
        }
    }
}
