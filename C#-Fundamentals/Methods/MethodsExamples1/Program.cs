using System;

namespace MethodsExamples1
{
    class Program
    {
        static void Main()
        {
            //double first = 1.22;
            //double second = 3.27;

            //double Result(double a, double b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine(Result(first, second));

            //int age = 17;
            //void PrintAgeAfter(int years) => Console.WriteLine(age + years);

            //PrintAgeAfter(3); // Output: 20

            double area(int r) => Math.PI * r * r;
            double perimeter(int r) => 2 * Math.PI * r;
            Console.WriteLine(area(3));
            Console.WriteLine(perimeter(3));
        }
    }
}
