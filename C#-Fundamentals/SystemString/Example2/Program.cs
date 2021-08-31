using System;
using System.Globalization;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "23.05.2021";
            string format = "dd.MM.yyyy";
            DateTime parsedDate = DateTime.ParseExact(
                text, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}",
                parsedDate.Day, parsedDate.Month, parsedDate.Year);
        }
    }
}
