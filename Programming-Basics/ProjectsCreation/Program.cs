using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {projectNum * 3} hours to complete {projectNum} project/s.");
        }
    }
}
