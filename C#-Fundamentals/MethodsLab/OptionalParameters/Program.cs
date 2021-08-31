using System;

namespace OptionalParameters
{
    class Program
    {
        static void PrintNumbers(int start = 0, int end = 100)
        {
            for (int i = start; i <= end; i++)
                Console.Write("{0} ", i);
        }

        // The above method can be called in several ways:
        // PrintNumbers(5, 10);
        // PrintNumbers(15);
        // PrintNumbers(end: 40, start: 35);
        // PrintNumbers();

        static void Main(string[] args)
        {

        }
    }
}
