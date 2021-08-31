using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Pesho";

            Console.WriteLine(person.FirstName);
        }
    }
}
