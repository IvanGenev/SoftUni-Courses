using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //int n = int.Parse(Console.ReadLine());

            //if (n < 1 || n > 7)
            //{
            //    Console.WriteLine("Invalid day!");
            //}
            //else
            //{
            //    var day = days[n - 1];
            //    Console.WriteLine(day);
            //}

            string[] months = {"January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "Decemner"};

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 12)
            {
                Console.WriteLine("Invalid month!");
            }
            else
            {
                var month = months[n - 1];
                Console.WriteLine(month);
            }
        }
    }
}
