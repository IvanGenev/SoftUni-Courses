using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                string model = inputData[0];
                int engineSpeed = int.Parse(inputData[1]);
                int enginePower = int.Parse(inputData[2]);
                int cargoWeight = int.Parse(inputData[3]);
                string cargoType = inputData[4];

                //double tire1Pressure = double.Parse(inputData[5]);
                //int tire1Age = int.Parse(inputData[6]);

                //double tire2Pressure = double.Parse(inputData[7]);
                //int tire2Age = int.Parse(inputData[8]);

                //double tire3Pressure = double.Parse(inputData[9]);
                //int tire3Age = int.Parse(inputData[10]);

                //double tire4Pressure = double.Parse(inputData[11]);
                //int tire4Age = int.Parse(inputData[12]);

                // or do it with less code - with for loop:
                List<Tire> tires = new List<Tire>();

                for (int tireIndex = 5; tireIndex <= 12; tireIndex += 2)
                {
                    double tirePressure = double.Parse(inputData[tireIndex]);
                    int tireAge = int.Parse(inputData[tireIndex + 1]);

                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string cargoTypeInput = Console.ReadLine();

            if (cargoTypeInput == "fragile")
            {
                List<Car> fragileCargo = cars
                    .Where(x => x.Cargo.Type == "fragile" &&
                    x.Tires.Any(t => t.Pressure < 1))
                    .ToList();

                foreach (var item in fragileCargo)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                List<Car> flammableCargo = cars
                    .Where(x => x.Cargo.Type == "flammable" &&
                    x.Engine.Power > 250)
                    .ToList();

                foreach (var item in flammableCargo)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
