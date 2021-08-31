using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            Queue<string> cars = new Queue<string>();
            int countCars = 0;

            while (command.ToUpper() != "END")
            {
                if (command.ToUpper() == "GREEN")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string passedCars = cars.Dequeue();
                            Console.WriteLine($"{passedCars} passed!");
                            countCars++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countCars} cars passed the crossroads.");
        }
    }
}
