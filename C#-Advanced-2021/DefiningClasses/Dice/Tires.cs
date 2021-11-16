using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox
{
    public class Tires
    {
        public Tires(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get; set; }
        public double Pressure { get; set; }
    }
}
