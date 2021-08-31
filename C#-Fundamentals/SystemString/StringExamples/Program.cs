using System;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "This \"is a simple string message.\"";

            Console.WriteLine("message = {0}", message);
            Console.WriteLine("message.Lenght = {0}", message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message[{0}] = {1}", i, message[i]);
            }
        }
    }
}
