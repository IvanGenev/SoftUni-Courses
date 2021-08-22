using System;

namespace Text_and_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there!");
            Console.ReadKey();
            Console.WriteLine();
            Console.Write("Tell me your First name - ");
            var firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Tell me your Last name - ");
            var lastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("... and your age is - ");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Finally, tell me your home town - ");
            var town = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("So, did I get you right?");
            Console.WriteLine();
            Console.WriteLine("You are " + firstName + " " + lastName + ", a " + age + "-year old, coming from" + " " + town + "!");
            Console.ReadKey();
        }
    }
}
