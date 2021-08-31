using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());

            int sumFirstAndSecond = firstDigit + secondDigit;
            int divideByThird = sumFirstAndSecond / thirdDigit;
            int multiplyByFourth = divideByThird * fourthDigit;

            Console.WriteLine(multiplyByFourth);
        }
    }
}
