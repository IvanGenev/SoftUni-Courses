using System;

namespace MathOperations
{
    class Program
    {
        static int GetMathResult(int firstNum, char operant, int secondNum)
        {
            int result = 0;

            switch (operant)
            {
                case '/':
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operant = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int mathResult = GetMathResult(firstNum, operant, secondNum);

            Console.WriteLine(mathResult);
        }
    }
}
