using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] trainWagon = new int[n];

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());

                trainWagon[i] = people;
            }

            int totalPeople = 0;

            for (int i = 0; i < trainWagon.Length; i++)
            {
                totalPeople += trainWagon[i];

                Console.Write(trainWagon[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPeople);
        }
    }
}
