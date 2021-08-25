using System;

namespace PointOnASegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (first <= point && point <= second || first >= point && point >= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            
            int a = Math.Abs(point - first);
            int b = Math.Abs(point - second);

            if (a > b)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
