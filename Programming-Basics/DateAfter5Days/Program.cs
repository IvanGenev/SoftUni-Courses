using System;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int daysInMonth = 31;
            if (m == 2)
            {
                daysInMonth = 28;
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                daysInMonth = 30;
            }
            d += 5;
            if (d > daysInMonth)
            {
                d -= daysInMonth;
                m++;
                if (m > 12)
                {
                    m = 1;
                }
            }
            Console.WriteLine("{0}.{1:d2}", d, m);
        }
    }
}
