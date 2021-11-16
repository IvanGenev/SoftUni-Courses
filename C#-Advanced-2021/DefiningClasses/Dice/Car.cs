using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox
{
    public class Car
    {
        public string Make { get; set; } = "BMW";
        public string Model { get; set; } = "E60";
        public int Year { get; set; } = 2004;
        public double FuelQuantity { get; set; } = 70.5;
        public double FuelConsumption { get; set; } = 7.2;

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tires[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}

