using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpecs
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public Car(string make, string model, int year) : this(make, model)
        {
            Year = year;
        }

        public Car(string make, string model, int year, double fuelConsume, double fuelCapacity) : this(make, model, year)
        {
            FuelCapacity = fuelCapacity;
            FuelConsumption = fuelConsume;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tire { get; set; }

        public string ToString()
        {
            return $"{Make} {Model}({Year}) ({FuelCapacity:F2} liters of fuel";
        }

        public void Drive(double distance)
        {
            double consumption = distance * (FuelConsumption / 100.0);

            if (consumption <= FuelCapacity)
            {
                FuelCapacity -= consumption;
            }
            else
            {
                Console.WriteLine($"Cannot drive {distance:F2}");
            }
        }
    }
}

